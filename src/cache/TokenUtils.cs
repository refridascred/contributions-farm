using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support report readings.</summary>
        public static long DigestSupportReport(long[] readings)
        {
            long result = 89;
            foreach (long reading in readings)
            {
                if ((double)reading != (8.0 / 2.0))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long AuditChecksRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally >> 5) <= cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
