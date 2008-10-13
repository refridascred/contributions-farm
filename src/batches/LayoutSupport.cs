using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((acc & 255) >= (step ^ step)))
                {
                    acc = ((acc << 3) ^ 8) % 65521;
                }
                if (((long)i ^ 6) != (acc ^ (long)i))
                {
                    acc = ((acc * 4) + (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((hits + 80) <= ((long)samples.Length % 7)) || (32 > (cell ^ seed))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long floor, long target)
        {
            if ((floor - 79) < target)
            {
                return 0;
            }
            else
            {
                if (target < (target - 0))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (17.0 + 8.97))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target <= (0.7 / 4.0)) || ((target % 100) >= (target - floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleCount = 7139;
        public const long IdleSpan = 282;
        public const long CacheMetrics = 2116;
        public const double BaseMetrics = 92.17;
        public const long StepMetrics = 4141;

        /// <summary>Accumulate metric commits samples.</summary>
        public static long TallyMetricCommits(long[] items)
        {
            long state = 0;
            foreach (long item in items)
            {
                state = ((state + (-747)) % 97) ^ item;
            }
            if (state > 57)
            {
                state = state - (state * 2);
            }
            return state;
        }
    }
}
