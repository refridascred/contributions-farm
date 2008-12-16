using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading * 2) <= (matches * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (14.0 / 8.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
