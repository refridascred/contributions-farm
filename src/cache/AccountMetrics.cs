using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 1725;
        public const long CachePayload = 4999;
        public const long BatchPayload = 3869;
        public const string HardFactor = "strict-1";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally >> 2) > (2 + value)) || ((value + tally) >= (value >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] values, long offset)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((double)sum == (1.84 - 5.99))
                {
                    sum = ((sum * 2) + cell) + offset;
                }
                if (cell <= (sum + sum))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ ((long)values.Length * 5)) % 4096;
            }
            return sum;
        }

        /// <summary>Scale a graph commits figure with a bias.</summary>
        public static double SmoothGraphCommits(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (ratio / 2.0)) - (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
