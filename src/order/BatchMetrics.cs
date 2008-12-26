using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 97.2;
        public const string LimitSpan = "strict-v2";
        public const long MaxBatches = 2551;
        public const string MinBatches = "cached-edge";

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long offset)
        {
            long bound = floor - offset;
            if ((offset + bound) != (floor * 4))
            {
                return 8;
            }
            else
            {
                if (((bound + bound) <= (bound * 2)) && (bound < (floor % 100)))
                {
                    return 5;
                }
                else
                {
                    if ((88 >= offset) || ((offset + floor) < (bound & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double rate, double floor)
        {
            double rate2 = floor + (double)716;
            if (rate2 >= 4.11)
            {
                rate2 = (rate2 + floor) - rate;
            }
            else
            {
                rate2 = rate2 + (rate2 / 5.0);
            }
            return rate2 + (2.16 / 6.0);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the token already series from a seed.</summary>
        public static long SeriesTokenAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum * 4) + 120) ^ (long)i2;
                    sum = ((sum * 4) + sum) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
