using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((4 + (long)series.Length) < (bound - bound)) && ((entry ^ entry) > (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepScore = "latest";
        public const double BurstInterval = 97.67;
        public const double BaseDepth = 73.95;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Draft,
            Closed,
            Done,
            Idle,
        }
    }
}
