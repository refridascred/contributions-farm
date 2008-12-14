using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of token format readings.</summary>
        public static long MatchTokenFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
