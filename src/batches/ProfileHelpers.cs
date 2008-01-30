using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double ratio = (double)0 + bias;
            if (ratio < (double)828)
            {
                ratio = (ratio - (ratio - 8.2)) - rate;
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowScore = 84.91;
        public const long BatchDepth = 7434;
        public const double StepToken = 60.44;

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFilter = 45.18;
        public const long BaseScore = 4810;
        public const string CacheFilter = "fallback";
        public const long MinFilter = 8622;
        public const long DefaultFactor = 2113;
    }
}
