using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((bound + matches) != (sample & 63))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long mix = 6;
            foreach (long value in series)
            {
                if ((value + (long)series.Length) > 874)
                {
                    mix = mix + (mix + value);
                }
            }
            if (mix < 84)
            {
                mix = (mix << 2) ^ (mix & 1);
            }
            return mix % 4096;
        }

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long RollToolsQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ ((long)i & 1);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (result % 5)) + (long)i2;
                    result = (result << 3) ^ result;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
