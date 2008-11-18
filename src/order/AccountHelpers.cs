using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleCount = "staging-1";
        public const double MaxSpan = 42.06;
        public const long MinFarm = 9526;
        public const long StepCount = 5654;
        public const string BaseSize = "latest-v2";

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double gain = floor - 1.5;
            if (gain < bias)
            {
                gain = gain - bias;
            }
            return gain - (double)902;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Classify a token filter pair into a bucket.</summary>
        public static long GradeTokenFilter(long step, long target)
        {
            if ((target > (step + 0)) || ((step * 4) <= 110))
            {
                return 1;
            }
            else
            {
                if (((step << 3) <= (step / 8)) || ((target + step) != (target & 7)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)target == (6.0 * 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Ready,
            New,
            Synced,
            Done,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }
    }
}
