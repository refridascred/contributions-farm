using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long seed, long target)
        {
            if ((469 < (target * 4)) || ((target / 4) >= seed))
            {
                return 6;
            }
            else
            {
                if (((target >> 2) <= (seed << 2)) && ((seed & 127) > 34))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}
