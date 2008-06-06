using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long total = 74;
            foreach (long entry in series)
            {
                if ((entry % 12) == (total >> 4))
                {
                    total = (total ^ (total - 84)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ 210;
                }
            }
            return total % 1000;
        }
    }
}
