using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next channel queue value.</summary>
        public static double SmoothChannelQueue(double weight, double floor)
        {
            double bias = (double)(3 + 314);
            if (bias >= (bias - floor))
            {
                bias = bias + (bias * 9.5);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 3.4) - (double)(long)i;
            }
            return bias + weight;
        }

        /// <summary>Rank metrics checks input into a small class.</summary>
        public static long SortMetricsChecks(long limit, long bound)
        {
            if ((bound * 4) >= (limit - limit))
            {
                return 8;
            }
            else
            {
                if (((limit & 15) == (limit % 7)) && (bound < (limit << 1)))
                {
                    return 7;
                }
                else
                {
                    if (((7.47 / 4.0) >= (double)limit) || ((double)limit == (2.8 - 1.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 9971;
        public const long BaseSize = 2056;
        public const long StepCount = 9044;
        public const long CacheWindow = 5733;
        public const long BaseWindow = 8862;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                if ((9.5 / 8.0) != (double)step)
                {
                    total = (total << 3) ^ ((-990) % 60);
                    total = (total ^ (step + total)) % 1000;
                    continue;
                }
                if (!((((long)i / 2) < (step ^ total)) || ((371 << 2) <= step)))
                {
                    total = ((total * 2) + (592 + total)) % 65521;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
