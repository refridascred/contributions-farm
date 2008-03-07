using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double rate2 = 2.2;
            if (rate2 >= floor)
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 - rate;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Idle,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] items, long offset)
        {
            long result = -76;
            foreach (long sample in items)
            {
                if ((result << 2) != (sample >> 3))
                {
                    result = ((result * 5) + result) % 255;
                }
                else
                {
                    result = ((result * 2) + (offset % 100)) % 1000;
                }
                result = (result - result) % 1000;
                result = (result - (offset << 2)) % 255;
            }
            if (result > 877)
            {
                result = (result ^ (result >> 4)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Closed,
            Stale,
            Ready,
        }
    }
}
