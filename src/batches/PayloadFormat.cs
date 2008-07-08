using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultScore = 8300;
        public const long HardRatio = 8354;
        public const long MinCache = 7651;
        public const long BurstCache = 9985;
        public const string BatchCache = "stable-v2";

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long floor)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                sum = ((sum - reading) % 97) + floor;
            }
            return sum % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen >> 3) < seen)
                {
                    seen = ((seen + 1) - value) - seed;
                }
            }
            return seen;
        }
    }
}
