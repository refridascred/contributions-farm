using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long seed2)
        {
            if (7 < (seed2 - seed2))
            {
                return 4;
            }
            else
            {
                if (seed2 <= (seed ^ seed2))
                {
                    return 6;
                }
                else
                {
                    if (!(((-68) - seed) != (seed2 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8378;
        public const string LimitMetrics = "primary-edge";
        public const double HardMetrics = 18.85;
        public const long BaseMetrics = 3764;
    }
}
