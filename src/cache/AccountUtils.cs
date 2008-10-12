using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long TallyPayloadToolsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 5) <= (1 << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count < (target - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data, long bound)
        {
            long carry = 477;
            foreach (long entry in data)
            {
                if ((9.1 + 2.8) >= (double)entry)
                {
                    carry = ((carry ^ (2 - carry)) % 255) - bound;
                }
            }
            return carry % 65521;
        }
    }
}
