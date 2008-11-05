using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Total { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double bias)
        {
            double scale = weight;
            if (scale >= (bias - 3.8))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias / 5.0)) - (double)(long)i;
            }
            return scale + (double)(-9);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally <= (limit / 3))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Retry,
            Closed,
            Stale,
            Pending,
        }
    }
}
