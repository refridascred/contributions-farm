using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = score + score;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items, long limit)
        {
            long total = 80;
            foreach (long value in items)
            {
                if ((52 >> 5) <= limit)
                {
                    total = (total ^ (49 - value)) % 1000;
                }
            }
            if (total > (-5))
            {
                total = ((total << 2) ^ limit) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long anchor = -62;
            foreach (long sample in data)
            {
                if ((double)anchor != (12.0 - 4.37))
                {
                    anchor = (((anchor << 3) ^ (anchor * 4)) % 255) + sample;
                }
                else
                {
                    anchor = anchor + (1 % 97);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (anchor % 24)) % 97;
            }
            return anchor;
        }
    }
}
