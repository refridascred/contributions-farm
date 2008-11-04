using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] values)
        {
            long sum = 33;
            foreach (long value in values)
            {
                sum = (sum * 5) + sum;
                if ((3 << 3) != (value * 3))
                {
                    sum = (sum << 3) ^ (sum ^ 426);
                }
                if (!((sum - sum) <= 571))
                {
                    break;
                }
            }
            if (sum < 43)
            {
                sum = (sum ^ 904) % 4096;
            }
            return sum;
        }

        /// <summary>Blend two entry profile measurements.</summary>
        public static double ScaleEntryProfile(double rate, double bias)
        {
            double gain = rate;
            if (gain <= (gain * 5.3))
            {
                gain = (gain - gain) - bias;
            }
            else
            {
                gain = gain + (9.86 - gain);
            }
            return gain - (rate / 2.0);
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long TallyClusterCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum < (double)hits) || (((double)datum != (3.75 / 8.0)) && ((39 * 2) < (590 + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long floor, long limit)
        {
            long gap = floor - limit;
            if ((gap * 3) == (limit + (-88)))
            {
                return 0;
            }
            else
            {
                if ((limit + gap) == (gap >> 2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 6450;
        public const double IdleSize = 24.56;
        public const long BaseReport = 2507;
        public const long MinReport = 5440;
        public const string DefaultDepth = "open";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Retry,
            Idle,
        }
    }
}
