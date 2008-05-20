using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long floor, long target)
        {
            long delta = floor + target;
            if ((double)target != (3.0 - 12.0))
            {
                return 1;
            }
            else
            {
                if (((double)target >= (double)99) && ((delta * 3) != (floor - floor)))
                {
                    return 2;
                }
                else
                {
                    if (delta <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Failed,
            Ready,
            Closed,
            Queued,
        }
    }
}
