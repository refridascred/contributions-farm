using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 81;
            foreach (long value in readings)
            {
                if (acc >= (value & 3))
                {
                    acc = acc - (value + value);
                }
            }
            if (acc > 264)
            {
                acc = (acc + (acc + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 7431;
        public const double MaxDepth = 64.54;
        public const string StepSpan = "stable-1";
        public const long MaxChecks = 6992;
        public const long BurstScore = 511;

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long target)
        {
            if ((double)532 != (double)target)
            {
                return 4;
            }
            else
            {
                if (((-87) ^ target) < (target + 52))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) >= (offset / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }
    }
}
