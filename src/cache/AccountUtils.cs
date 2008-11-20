using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values)
        {
            long score = 7;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = ((score * 3) + 63) + (long)i;
                }
                score = ((score << 3) ^ (sample - score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((value >> 5) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
