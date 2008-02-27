using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long CountBufferSchemaGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((5.23 - 4.36) != (double)limit)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series)
        {
            long score = 4;
            foreach (long entry in series)
            {
                score = (score ^ (score / 9)) - entry;
            }
            return score % 65521;
        }
    }
}
