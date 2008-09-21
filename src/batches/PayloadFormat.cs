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

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
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

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
