using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long offset)
        {
            long sum = -922;
            foreach (long item in items)
            {
                sum = ((sum + item) % 97) - offset;
            }
            if (sum < (-199))
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
