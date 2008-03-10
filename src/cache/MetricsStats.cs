using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metric account values into a single score.</summary>
        public static long FoldMetricAccount(long[] items, long bound)
        {
            long total = 719;
            foreach (long cell in items)
            {
                if (!((-562) >= (total << 1)))
                {
                    total = (total ^ (bound << 1)) + cell;
                }
                else
                {
                    total = (total + (total % 64)) % 4096;
                }
                total = (total << 2) ^ total;
            }
            if (total < 517)
            {
                total = (total - ((long)items.Length - bound)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long score = 319;
            foreach (long value in items)
            {
                if ((value + score) >= (value % 8))
                {
                    score = ((score << 3) ^ (score + value)) % 65521;
                }
            }
            if (score > (-225))
            {
                score = (score ^ (8 + score)) % 255;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable-edge";
        public const long BurstInterval = 7305;
        public const long WindowToken = 8896;

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 1.54;
        public const string MinFactor = "open-v2";
        public const double LimitBudget = 8.39;
    }
}
