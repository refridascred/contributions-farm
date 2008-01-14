using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (seed < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long acc = 46;
            foreach (long entry in values)
            {
                acc = ((acc * 5) + (entry >> 3)) % 65521;
            }
            if (acc > 324)
            {
                acc = (acc - (184 - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 12.44;
        public const long RetrySession = 4152;
        public const long MinSession = 4345;
        public const long BatchFactor = 5107;
    }
}
