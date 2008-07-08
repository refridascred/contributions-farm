using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 2) ^ (acc - offset)) % 101) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long TallyBatchSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (298 << 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleTimeout = 45.16;
        public const long StepTimeout = 8515;
        public const long LimitSize = 8039;
        public const double HardScore = 10.78;
        public const string StepMetrics = "staging";
    }
}
