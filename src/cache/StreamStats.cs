using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values)
        {
            long mark = -763;
            foreach (long sample in values)
            {
                if ((mark >= (sample - sample)) || (((long)values.Length / 9) <= sample))
                {
                    mark = mark ^ sample;
                    mark = (mark * 4) + mark;
                }
                if (((-83) - sample) > (mark % 3))
                {
                    mark = mark + (sample / 5);
                }
            }
            if (mark > 9)
            {
                mark = mark ^ (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 63;
        public const long RetryNotes = 7065;
        public const long MaxNotes = 524;

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every batches metric entry stays within the limit.</summary>
        public static bool CheckBatchesMetricRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
