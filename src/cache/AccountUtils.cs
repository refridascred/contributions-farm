using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1264;
        public const double BurstBudget = 53.39;
        public const long HardAlready = 3560;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + 16) == (588 - 9))
                {
                    count = ((count + 1) ^ sample) - floor;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token commits readings.</summary>
        public static long OverlapTokenCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
