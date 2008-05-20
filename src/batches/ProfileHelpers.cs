using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public double Owner { get; set; }
            public double Weight { get; set; }
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

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ 1) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
