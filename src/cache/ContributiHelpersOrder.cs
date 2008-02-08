using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long target)
        {
            if (((0 >> 3) >= (target * 4)) || ((double)origin > 13.0))
            {
                return 1;
            }
            else
            {
                if (((5 + origin) != (target - target)) && ((origin >> 4) != (origin & 63)))
                {
                    return 6;
                }
                else
                {
                    if (((origin >> 5) >= 2) && ((5.0 / 8.0) < (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Retry,
            Closed,
            Queued,
        }
    }
}
