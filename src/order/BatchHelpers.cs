using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long AuditSchemaEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) > (966 + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] series, long seed)
        {
            long result = 886;
            foreach (long reading in series)
            {
                if ((reading + 21) <= result)
                {
                    result = (result << 3) ^ (seed & 255);
                }
            }
            return result % 65521;
        }
    }
}
