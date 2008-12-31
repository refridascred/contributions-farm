using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 1425;
        public const double BurstFormat = 9.02;
        public const long DefaultWidth = 614;
        public const string BatchFormat = "strict-edge";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
