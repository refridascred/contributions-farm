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

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double offset)
        {
            double gain2 = offset * 9.7;
            if (gain2 >= 2.8)
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (double)8;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
