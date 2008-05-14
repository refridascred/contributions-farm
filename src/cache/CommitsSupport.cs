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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Total { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
