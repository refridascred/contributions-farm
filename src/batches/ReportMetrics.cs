using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double bias2 = (double)813 / 3.0;
            if (bias2 >= bias2)
            {
                bias2 = ((bias2 + (1.7 * 1.4)) - rate) + bias;
            }
            return bias2 - 20.0;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((3.3 * 5.34) >= (double)seed))
                {
                    sum = (sum << 2) ^ (seed + seed);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every filter payload entry stays within the limit.</summary>
        public static bool VerifyFilterPayloadBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
