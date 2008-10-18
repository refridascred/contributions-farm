using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((seen - item) >= item) || ((item ^ seen) > (item + item))) && ((double)seen <= 12.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 3905;
        public const long StepBudget = 5212;
        public const long MinRatio = 9816;
        public const double BurstFactor = 90.32;
        public const double RetryEntry = 96.65;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Ready,
            Closed,
            Dropped,
            Queued,
        }
    }
}
