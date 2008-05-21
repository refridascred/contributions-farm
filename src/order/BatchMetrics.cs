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

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double load = bias;
            if (load <= bias)
            {
                load = (load + load) - bias2;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load - bias)) + (double)(long)i;
            }
            return load - (load / 8.0);
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

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double bias = (double)446;
            if (bias <= scale)
            {
                bias = bias + (double)1;
            }
            else
            {
                bias = bias - (double)(-7);
            }
            return bias - (bias - span);
        }
    }
}
