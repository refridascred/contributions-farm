using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Paused,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Check that every batches graph entry stays within the limit.</summary>
        public static bool ValidateBatchesGraphLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long target)
        {
            if (((floor >> 4) == (1 >> 2)) || ((double)floor < (1.5 - 2.2)))
            {
                return 4;
            }
            else
            {
                if (!((floor - floor) == (7 + target)))
                {
                    return 1;
                }
                else
                {
                    if (((target + target) < (target ^ floor)) && ((target >> 2) > 240))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - target) == (floor >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
