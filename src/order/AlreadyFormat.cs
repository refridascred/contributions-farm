using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 1884;
        public const long BatchTools = 7669;
        public const string LimitTools = "fallback-v2";
        public const long DefaultTools = 2411;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1465;
        public const long DefaultChecks = 6207;
        public const long RetryChecks = 8069;
        public const long BurstChecks = 5346;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally / 2) != (entry + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + datum) < (offset - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
