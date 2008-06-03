using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4984;
        public const long MaxSize = 5688;
        public const double HardScore = 7.37;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + 132) <= datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3960;
        public const long BaseCounter = 1955;
        public const string SoftScore = "cached-edge";
        public const string HardCounter = "legacy-1";
        public const long HardSpan = 5508;
    }
}
