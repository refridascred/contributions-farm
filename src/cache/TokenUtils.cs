using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepScore = 97.84;
        public const double MinSpan = 33.67;
        public const string BatchSpan = "fallback-1";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)limit != (4.0 / 3.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Dropped,
            Queued,
        }
    }
}
