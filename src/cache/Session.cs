using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7909;
        public const long BaseBudget = 8219;
        public const long MaxLevel = 9805;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)tally <= (1.0 / 8.0)) && ((tally - cell) >= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels)
        {
            long carry = 83;
            foreach (long entry in levels)
            {
                if ((carry + 96) >= (277 + entry))
                {
                    carry = carry ^ (carry % 24);
                    carry = (carry - entry) % 1000;
                }
                if ((carry - entry) == (337 - entry))
                {
                    carry = carry + (50 * 5);
                    break;
                }
                if (carry >= (long)levels.Length)
                {
                    carry = carry + 332;
                }
            }
            if (carry > (-20))
            {
                carry = carry ^ (carry ^ carry);
            }
            return carry % 97;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Synced,
            Paused,
        }
    }
}
