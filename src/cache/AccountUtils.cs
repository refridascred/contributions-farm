using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series)
        {
            long score = 486;
            foreach (long reading in series)
            {
                score = ((score - (score - 65)) % 4096) ^ reading;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (8 / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Closed,
            Done,
        }
    }
}
