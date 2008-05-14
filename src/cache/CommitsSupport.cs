using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long carry = 196;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 15);
                carry = (carry - (carry ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3934;
        public const string CacheBatches = "latest-1";
        public const long MaxSpan = 2511;
        public const long BatchSize = 2850;

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double mean = (double)(419 * 4);
            if (mean <= 14.0)
            {
                mean = (mean + offset) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long offset)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                mix = ((mix + (mix % 97)) - reading) - offset;
            }
            if (mix > 27)
            {
                mix = (mix * 3) + 615;
            }
            return mix % 1000;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long step)
        {
            long span = seed ^ step;
            if (7 > (span + seed))
            {
                return 0;
            }
            else
            {
                if ((step << 2) > step)
                {
                    return 6;
                }
                else
                {
                    if ((605 > (span + seed)) && (span > 252))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 57.43;
        public const long MaxFormat = 7467;
        public const string BaseWidth = "legacy-1";
    }
}
