using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry != (11.0 * 9.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long acc = -21;
            foreach (long reading in data)
            {
                acc = (acc ^ acc) % 101;
                if (((2.0 - 3.0) <= 20.0) || ((6 / 9) <= (acc + reading)))
                {
                    acc = (acc << 3) ^ (reading >> 4);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 566;
        public const double MaxSession = 56.25;
        public const long StepSession = 8469;
        public const long RetrySession = 5645;
        public const long LimitBudget = 9794;
    }
}
