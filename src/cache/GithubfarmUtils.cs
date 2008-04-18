using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a payload batches pair into a bucket.</summary>
        public static long RankPayloadBatches(long offset, long target)
        {
            if (((57 & 3) <= offset) || (offset >= (target >> 4)))
            {
                return 4;
            }
            else
            {
                if ((offset / 9) != (target / 2))
                {
                    return 5;
                }
                else
                {
                    if (6.95 > (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - target) <= (offset / 6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks session entry stays within the limit.</summary>
        public static bool ValidateChecksSessionLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Locked,
            Dropped,
            Stale,
        }
    }
}
