using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + count) < count)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchSpan = 5169;
        public const string BaseBuffer = "alpha-edge";
        public const long StepBuffer = 8167;
        public const long MaxBuffer = 2115;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits >= (43 - hits))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
