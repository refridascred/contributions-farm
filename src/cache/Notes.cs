using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            if ((floor <= (seed << 1)) || ((seed & 127) >= (floor & 15)))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed % 24))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 255) > (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double gain2 = (double)719 - gain;
            if (gain2 <= (double)9)
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain2 / 6.0)) + (double)(long)i;
            }
            return gain2 - (gain * 6.08);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryRatio = 6005;
        public const long HardBudget = 5818;
        public const double SoftDepth = 50.14;
        public const double BaseSize = 46.11;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
