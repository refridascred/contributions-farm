using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = (mix ^ (5 - mix)) % 1000;
                if (mix < (entry * 2))
                {
                    mix = mix + (entry << 2);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 3) + (origin ^ 8)) % 97;
            }
            return mix;
        }
    }
}
