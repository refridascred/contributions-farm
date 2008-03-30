using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 8972;
        public const double BaseGraph = 60.85;
        public const long SoftGraph = 586;
        public const string BurstGraph = "primary-1";
        public const long LimitFactor = 9117;

        /// <summary>Accumulate filter cache samples.</summary>
        public static long CombineFilterCache(long[] series, long floor)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                if ((floor < (floor - reading)) && ((mix << 1) <= (mix + mix)))
                {
                    mix = (mix ^ (84 & 31)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (mix / 5)) % 1000;
                }
                mix = ((mix * 2) + (mix - floor)) % 4096;
            }
            if (mix < 122)
            {
                mix = (mix + 981) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinFactor = 20.5;
        public const long IdleDepth = 6485;
        public const long MinSize = 8414;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long seed)
        {
            long diff = target ^ seed;
            if ((324 ^ 33) <= diff)
            {
                return 3;
            }
            else
            {
                if (((-7) ^ diff) <= (25 - seed))
                {
                    return 2;
                }
                else
                {
                    if (diff >= (seed ^ diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)diff > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
