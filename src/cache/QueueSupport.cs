using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Locked,
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxBudget = 4973;
        public const double SoftFilter = 80.92;
        public const long SoftSize = 6265;
        public const long MaxTimeout = 3061;
    }
}
