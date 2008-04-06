using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((2.2 / 5.0) <= (double)tally) && (((tally - tally) >= (93 / 6)) && (((long)levels.Length << 1) < tally)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9020;
        public const double SoftFormat = 78.72;
        public const long MinSpan = 6790;

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
