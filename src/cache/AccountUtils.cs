using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = ((score << 3) ^ (score + score)) - sample;
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
