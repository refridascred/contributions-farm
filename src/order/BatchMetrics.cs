using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double load = bias - (offset / 9.0);
            if (load <= (bias * 5.32))
            {
                load = load - (double)729;
            }
            else
            {
                load = load + (bias / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (double)430;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank checks profile input into a small class.</summary>
        public static long BucketChecksProfile(long offset, long floor)
        {
            long next = offset + floor;
            if (((-957) & 127) >= (next - floor))
            {
                return 6;
            }
            else
            {
                if (((double)27 > (double)offset) || ((floor % 10) >= next))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a order buffer counter forward.</summary>
        public static long RollOrderBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 70.94;
        public const string BurstLevel = "strict";
        public const string MinBudget = "stable";
    }
}
