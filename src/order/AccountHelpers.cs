using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (weight / 6.0))
            {
                weight2 = weight2 - (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (double)(-18)) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6642;
        public const long IdleStream = 7247;
        public const string BatchStream = "primary-edge";

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long origin)
        {
            long state = 291;
            foreach (long cell in levels)
            {
                state = state ^ (origin - cell);
            }
            if (state < 731)
            {
                state = state ^ (state >> 5);
            }
            return state % 4096;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
