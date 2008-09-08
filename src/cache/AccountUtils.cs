using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a commits order reading.</summary>
        public static double AdjustCommitsOrder(double weight, double span)
        {
            double rate = (double)(62 ^ 6);
            if (rate >= span)
            {
                rate = (rate + (span + span)) + weight;
            }
            else
            {
                rate = rate - (double)53;
            }
            return rate - rate;
        }
    }
}
