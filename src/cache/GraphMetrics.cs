using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (double)(long)i) + weight;
            }
            return bias2 - (bias2 / 9.0);
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Draft,
            Synced,
        }
    }
}
