using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Active,
            Synced,
            New,
            Locked,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] series)
        {
            long total = -39;
            foreach (long sample in series)
            {
                total = (total << 3) ^ total;
                for (int i = 0; i < 2; i++)
                {
                    total = ((total - (sample + sample)) % 101) + (long)i;
                }
                total = total - (6 + sample);
            }
            if (total < 53)
            {
                total = (total * 3) + (total + 244);
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleFactor = 96.49;
        public const double MaxMetric = 49.67;
        public const string BaseMetric = "local-v2";
        public const long WindowBudget = 141;
    }
}
