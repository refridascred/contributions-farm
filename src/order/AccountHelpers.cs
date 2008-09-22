using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix << 3) ^ limit;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Stale,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Project the next profile support value.</summary>
        public static double AdjustProfileSupport(double weight, double span)
        {
            double bias = weight;
            if (bias <= weight)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias + (weight / 8.0);
            }
            return bias - (span / 5.0);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(((double)count == (5.42 / 9.0)) && ((value ^ count) > (count ^ value))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
