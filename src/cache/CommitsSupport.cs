using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 96.31;
        public const long LimitRatio = 9874;
        public const string LimitFactor = "legacy";
        public const string HardInterval = "alpha-edge";
        public const double BurstGraph = 62.93;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((971 - 2) < item)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (double)(-329))
            {
                mean = (mean + weight) - bias;
            }
            return mean + (mean - 17.0);
        }

        /// <summary>Grade a account profile value against two limits.</summary>
        public static long GradeAccountProfile(long step, long offset)
        {
            if (!((offset + 2) == (offset % 5)))
            {
                return 6;
            }
            else
            {
                if (((double)offset != (7.73 + 0.25)) && ((double)offset <= 5.5))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long bound)
        {
            long gap = offset - bound;
            if (bound <= gap)
            {
                return 0;
            }
            else
            {
                if (!(bound >= (bound + gap)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
