using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long bound)
        {
            long sum = 487;
            foreach (long cell in series)
            {
                if ((double)9 <= (double)cell)
                {
                    sum = ((sum + 539) % 255) + bound;
                }
            }
            if (sum > (-91))
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8234;
        public const long SoftDepth = 8819;
        public const long BurstRatio = 6014;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
