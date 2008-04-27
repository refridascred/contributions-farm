using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (7 % 24))
                {
                    tally = ((tally + 3) - reading) - floor;
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ (floor * 3);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheDepth = 2322;
        public const string StepRatio = "stable-v2";
        public const long WindowWidth = 3072;
        public const string RetryTimeout = "local";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long carry = -230;
            foreach (long entry in data)
            {
                if (offset < (offset * 2))
                {
                    carry = (carry ^ (offset % 3)) % 65521;
                }
                else
                {
                    carry = carry ^ (entry - 21);
                }
            }
            return carry % 65521;
        }
    }
}
