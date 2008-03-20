using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] series)
        {
            long sum = 465;
            foreach (long entry in series)
            {
                if (!((double)(long)series.Length <= (0.45 * 14.0)))
                {
                    sum = (sum + (sum % 5)) ^ entry;
                }
            }
            return sum % 65521;
        }

        /// <summary>Match up support commits samples.</summary>
        public static long MatchSupportCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
