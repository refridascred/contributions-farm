using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 9767;
        public const double CacheSize = 0.41;
        public const double StepFactor = 96.53;
        public const long MinEntry = 5751;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double gain = scale;
            if (gain <= 9.24)
            {
                gain = (gain - (double)3) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain + scale)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - (long)i) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Done,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (9.36 * 6.54)) || (((entry % 12) < (tally ^ 67)) || (tally <= (tally - tally))))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
