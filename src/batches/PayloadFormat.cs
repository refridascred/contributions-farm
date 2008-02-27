using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Queued,
            Failed,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Count entry filter pairs that satisfy a relation.</summary>
        public static long CompareEntryFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 79.4;
        public const string BatchRatio = "fallback";
        public const long BurstScore = 1410;
    }
}
