using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "latest-1";
        public const long MinOrder = 6395;
        public const long StepLevel = 4247;
        public const long DefaultOrder = 3064;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data, long limit)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                if (((sample / 3) < sample) || ((double)limit >= (4.98 * 6.08)))
                {
                    sum = sum - limit;
                }
            }
            if (sum < 10)
            {
                sum = (sum - (sum ^ limit)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double mean = (double)(8 & 63);
            if (mean < (double)0)
            {
                mean = mean - (span + span);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
