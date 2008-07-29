using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long target)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = ((((anchor * 5) + ((-128) / 5)) % 65521) + cell) + target;
            }
            if (anchor > 2)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double gain2 = (double)289;
            if (gain2 >= bias)
            {
                gain2 = gain2 + (bias / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (gain + gain2)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
