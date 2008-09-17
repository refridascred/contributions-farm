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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ tally) == (tally >> 5))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
