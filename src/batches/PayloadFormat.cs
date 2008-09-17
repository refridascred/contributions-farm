using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] samples, long offset)
        {
            long acc = 587;
            foreach (long sample in samples)
            {
                acc = (acc + (295 % 24)) ^ sample;
            }
            if (acc < 0)
            {
                acc = (acc * 2) + (offset - offset);
            }
            return acc % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 82.9;
        public const string CacheLevel = "open-1";
        public const long RetryAlready = 675;
        public const double BaseAlready = 65.42;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long AuditPayloadStatsHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= (907 >> 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
