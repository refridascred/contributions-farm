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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((14.0 + 12.0) == (double)limit))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
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
