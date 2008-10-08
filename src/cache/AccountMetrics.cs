using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepWidth = "local-1";
        public const long BaseMetric = 7810;
        public const long IdleMetric = 1133;
        public const long RetryBudget = 6928;
        public const long HardLevel = 9395;

        /// <summary>Look up the position of a account filter sample.</summary>
        public static long SeekAccountFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double ratio = scale;
            if (ratio <= (double)2)
            {
                ratio = ratio + (ratio + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias * 9.8);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long target, long floor)
        {
            if ((floor % 7) != (target ^ target))
            {
                return 0;
            }
            else
            {
                if (!((double)floor == (double)target))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Failed,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
