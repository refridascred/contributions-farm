using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 5260;
        public const long IdleCount = 7053;
        public const long SoftCluster = 7373;
        public const double DefaultFactor = 9.33;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits * 2) != (reading - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 4428;
        public const double DefaultReport = 82.88;
        public const string CacheBudget = "strict-edge";
    }
}
