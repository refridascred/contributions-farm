using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits checks value from a seed.</summary>
        public static long IterateCommitsChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i >= 6)
                {
                    sum = sum ^ (offset / 5);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long mark = 537;
            foreach (long cell in data)
            {
                if ((double)limit > 3.78)
                {
                    mark = ((mark * 5) + cell) % 101;
                }
            }
            if (mark > 68)
            {
                mark = mark + 394;
            }
            return mark % 97;
        }
    }
}
