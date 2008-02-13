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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) <= (924 >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
