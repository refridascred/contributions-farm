using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long step)
        {
            long anchor = 7;
            foreach (long reading in values)
            {
                if ((58 - 62) < step)
                {
                    anchor = anchor - (reading ^ anchor);
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 7);
                }
            }
            return anchor;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxDepth = 67.49;
        public const long BurstTimeout = 8256;
        public const double HardBudget = 46.9;
        public const long LimitFilter = 8118;
    }
}
