using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long target)
        {
            long slot = bound + target;
            if (!(target < (bound >> 1)))
            {
                return 6;
            }
            else
            {
                if (bound > (target / 8))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot <= (2.8 * 3.33))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((slot & 127) != (bound ^ (-1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
