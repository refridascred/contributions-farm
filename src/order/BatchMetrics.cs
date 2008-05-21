using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long limit)
        {
            long next = seed + limit;
            if ((double)next > (0.02 - 9.79))
            {
                return 2;
            }
            else
            {
                if ((next * 2) < (-9))
                {
                    return 3;
                }
                else
                {
                    if ((seed / 2) < (seed / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSize = 3824;
        public const string BaseBatches = "standard-v2";
        public const string BaseTimeout = "primary-v2";
        public const string SoftBatches = "standard-v2";

        /// <summary>Adjust a layout schema reading.</summary>
        public static double BlendLayoutSchema(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)4) - (double)(long)i;
            }
            return rate - (gain / 5.0);
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 8141;
        public const double MinRatio = 95.75;
        public const string BatchGithubfarm = "stable";
    }
}
