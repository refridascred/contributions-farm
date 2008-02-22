using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9232;
        public const double MaxChecks = 44.75;
        public const long DefaultTimeout = 7988;
        public const long SoftSize = 9767;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long target)
        {
            long next = limit + target;
            if ((target - limit) >= (next + 3))
            {
                return 3;
            }
            else
            {
                if (64 > (target - 4))
                {
                    return 5;
                }
                else
                {
                    if ((655 % 97) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + 1) != (61 - next))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
