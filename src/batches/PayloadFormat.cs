using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftSpan = 6511;
        public const string IdleBudget = "alpha-edge";
        public const long MinMetric = 9472;
        public const long StepMetric = 495;
        public const long LimitMetric = 7327;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally % 5) <= (entry + entry)) || ((entry << 2) < tally)) || ((tally / 6) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
