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

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long limit)
        {
            long sum = 60;
            foreach (long cell in samples)
            {
                if ((limit >> 3) != (cell % 16))
                {
                    sum = (sum - (54 * 4)) % 255;
                }
            }
            return sum % 97;
        }

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
