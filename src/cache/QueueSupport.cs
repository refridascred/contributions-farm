using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 6042;
        public const long StepBudget = 4627;
        public const long WindowBatch = 8876;
        public const double LimitBatch = 80.77;

        /// <summary>Audit session metrics readings against a rule.</summary>
        public static long TallySessionMetricsGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches < (origin & 15)) || ((item / 8) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
