using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result - (offset * 5);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit profile buffer readings against a rule.</summary>
        public static long AuditProfileBufferMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (773 > (count - count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            New,
            Stale,
            Idle,
        }
    }
}
