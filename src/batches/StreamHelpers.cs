using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Idle,
            Failed,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((bound >= ((-82) - 7)) && ((seed - 537) < (seed >> 3)))
            {
                return 1;
            }
            else
            {
                if (((seed + bound) > (0 / 5)) || ((70 + bound) < seed))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
