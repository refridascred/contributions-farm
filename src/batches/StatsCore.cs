using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((70 * 5) <= (offset ^ 34))
                {
                    acc = (acc + (acc ^ 963)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 3274;
        public const long MaxFactor = 5104;
        public const long CacheTools = 507;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long offset)
        {
            if (12.0 >= (double)step)
            {
                return 6;
            }
            else
            {
                if (((offset - 729) > (step * 5)) && ((offset >> 2) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    if (!((offset >> 2) == (offset % 10)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double rate = (bias * 9.6) - (3.75 / 9.0);
            if (rate < (floor + bias))
            {
                rate = rate + bias;
            }
            return rate + (5.78 + bias);
        }

        /// <summary>Check that every account batches entry stays within the limit.</summary>
        public static bool ValidateAccountBatchesLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
