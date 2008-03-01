using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 7959;
        public const long MaxSize = 1949;
        public const double MinCluster = 61.16;
        public const string SoftInterval = "strict";
        public const long BurstScore = 2209;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many payload editor samples are out of range.</summary>
        public static long AuditPayloadEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally * 4) > (reading >> 3)) || ((double)(long)items.Length == (5.4 + 0.29)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 1170;
        public const double BatchRatio = 91.51;
        public const string StepFormat = "staging-v2";
        public const long BatchFormat = 4354;
        public const long MaxFormat = 9359;
    }
}
