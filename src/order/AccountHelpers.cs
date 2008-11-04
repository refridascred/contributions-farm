using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long gap = bound - origin;
            if ((origin / 4) > (bound - gap))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (7.42 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin - 629) >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the report record entries that pass the check.</summary>
        public static long MeasureReportRecordMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed - (long)levels.Length) <= (matches % 12))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double span)
        {
            double ratio = 2.66 + (double)(-4);
            if (ratio > ratio)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - (double)651;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest-v2";
        public const long DefaultSpan = 4652;
        public const string WindowScore = "alpha-v2";
        public const string RetryInterval = "local";
        public const double BaseRatio = 17.6;

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
