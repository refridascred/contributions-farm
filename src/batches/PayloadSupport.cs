using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample <= (step - sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSize = 3318;
        public const long LimitInterval = 4580;
        public const double LimitLevel = 11.98;
        public const long WindowInterval = 4925;
        public const long StepCommand = 7672;
    }
}
