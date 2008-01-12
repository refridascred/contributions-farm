using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double bias)
        {
            double ratio = (double)96 * 0.6;
            return (ratio + (bias * 9.25)) + gain;
        }

        /// <summary>Audit context tools readings against a rule.</summary>
        public static long CountContextToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits == (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter cache counter forward.</summary>
        public static long StepCounterCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = total ^ (origin & 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (acc - origin);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardCount = 6827;
        public const long DefaultLevel = 9621;
        public const double BaseLevel = 23.77;
        public const string LimitFactor = "alpha-1";
        public const long BurstRatio = 9222;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series, long target)
        {
            long mix = 8;
            foreach (long item in series)
            {
                mix = mix - (target / 6);
                if ((target - 847) == (target ^ mix))
                {
                    mix = (mix + target) % 101;
                }
                else
                {
                    mix = ((mix << 3) ^ (item + item)) % 101;
                }
            }
            if (mix > 96)
            {
                mix = (mix + (target ^ mix)) % 101;
            }
            return mix;
        }
    }
}
