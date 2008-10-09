using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (7.6 <= (double)matches)
                {
                    matches = ((matches + 1) + datum) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double ratio = floor / 9.0;
            if (ratio < (double)2)
            {
                ratio = (ratio + (double)76) - rate;
            }
            else
            {
                ratio = ratio - (floor * 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 0.1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long bound)
        {
            long anchor = 14;
            foreach (long value in data)
            {
                long edge = 4 % 100;
                if ((value << 2) < value)
                {
                    anchor = (anchor << 3) ^ (6 * 5);
                    anchor = (anchor ^ (bound + edge)) % 97;
                }
                anchor = (anchor + (bound * 5)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
