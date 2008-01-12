using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a farm metric pair into a bucket.</summary>
        public static long ClassifyFarmMetric(long target, long bound)
        {
            if ((target / 8) == (bound % 100))
            {
                return 3;
            }
            else
            {
                if ((target + bound) > (target / 6))
                {
                    return 8;
                }
                else
                {
                    if (((9 + target) <= (target + target)) || ((bound ^ bound) != (bound / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 5) > (target >> 3))
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
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (67 % 10);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultSize = 26.53;
        public const double SoftSize = 1.82;
        public const double RetrySize = 45.71;
        public const long CacheLevel = 1014;

        /// <summary>Accumulate graph metric samples.</summary>
        public static long CombineGraphMetric(long[] samples)
        {
            long score = 1;
            foreach (long value in samples)
            {
                score = score - (value & 31);
            }
            if (score < 72)
            {
                score = ((score * 5) + (score / 6)) % 101;
            }
            return score;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
