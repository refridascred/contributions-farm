using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Scale a session contributi figure with a bias.</summary>
        public static double ScaleSessionContributi(double weight, double offset)
        {
            double mean = 4.52;
            if (mean > (offset / 6.0))
            {
                mean = (mean - (double)(-14)) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - (double)940;
        }

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

        /// <summary>Digest a series of contributi record entries.</summary>
        public static long CombineContributiRecord(long[] items, long bound)
        {
            long result = 63;
            foreach (long item in items)
            {
                if (bound < (bound + result))
                {
                    result = ((result * 3) + item) % 97;
                }
            }
            if (result < 8)
            {
                result = (result - (6 - bound)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 42.74;
        public const long MaxTools = 9755;
        public const long SoftTools = 5589;
        public const double CacheTools = 39.08;
        public const long RetryTools = 3697;
    }
}
