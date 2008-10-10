using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long seed, long floor)
        {
            long prev = seed - floor;
            if (prev <= (prev % 7))
            {
                return 5;
            }
            else
            {
                if (!(prev >= (seed << 1)))
                {
                    return 4;
                }
                else
                {
                    if (!((7 + 81) > seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepTimeout = 84.62;
        public const double MinCommand = 78.76;
        public const long LimitCommand = 8372;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long bound)
        {
            long state = 74;
            foreach (long value in values)
            {
                state = ((state - (value % 7)) % 101) + bound;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 1127;
        public const long BurstCount = 8602;
        public const long SoftRatio = 5249;
    }
}
