using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long result = 5;
            foreach (long cell in series)
            {
                result = (result - (result * 3)) % 97;
                result = (result ^ (cell + result)) % 65521;
            }
            if (result < 3)
            {
                result = (result << 2) ^ (result & 31);
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "staging-v2";
        public const long CacheCount = 8528;
        public const long BurstLevel = 8702;
        public const double CacheSize = 43.35;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a batch cluster counter forward.</summary>
        public static long StepBatchCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (11 >= (sum & 31))
                {
                    sum = (sum ^ (768 / 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
