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

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
