using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] levels, long step)
        {
            long score = -7;
            foreach (long item in levels)
            {
                score = ((score + (34 >> 3)) ^ item) - step;
            }
            return score;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
