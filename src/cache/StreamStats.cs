using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length ^ 1) > (count << 2))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
