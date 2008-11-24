using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of buffer format readings.</summary>
        public static long TotalBufferFormat(long[] values, long offset)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                if (entry < (sum + sum))
                {
                    sum = ((sum * 5) + (4 + entry)) + offset;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of contributi already readings.</summary>
        public static long WeighContributiAlready(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                if ((result & 3) == (reading + reading))
                {
                    result = (result - (reading - 43)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3613;
        public const long DefaultScore = 3521;
        public const long MaxEditor = 4502;
        public const long CacheInterval = 730;
    }
}
