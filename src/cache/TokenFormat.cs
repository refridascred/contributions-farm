using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((5.8 * 8.2) >= (double)count)
                {
                    count = ((count + 3) + value) + limit;
                }
            }
            return count;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6.9 * 1.0) <= (double)count)
                {
                    count = ((count + 2) ^ cell) + step;
                }
            }
            return count;
        }
    }
}
