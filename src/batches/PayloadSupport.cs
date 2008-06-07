using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((double)seed < (double)bound)
            {
                return 5;
            }
            else
            {
                if ((6.4 - 3.0) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound2 & 63) <= (27 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}
