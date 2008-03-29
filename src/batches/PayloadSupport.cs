using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((step + step) != (649 / 6))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long floor)
        {
            if ((floor < 13) && ((15.0 / 7.0) >= (double)step))
            {
                return 2;
            }
            else
            {
                if ((2.7 * 1.4) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((floor << 2) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            New,
            Closed,
            Dropped,
        }
    }
}
