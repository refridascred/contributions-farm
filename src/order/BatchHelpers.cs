using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 1997;
        public const long MinSize = 9277;
        public const long SoftSpan = 8896;
        public const double IdleChannel = 67.75;
        public const long BatchFactor = 4539;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - origin) < (-5))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm payload readings.</summary>
        public static long WeighFarmPayload(long[] levels, long bound)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = ((score - (bound << 1)) % 4096) - reading;
            }
            return score % 4096;
        }
    }
}
