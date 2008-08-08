using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values, long origin)
        {
            long carry = 8;
            foreach (long entry in values)
            {
                if (origin < entry)
                {
                    carry = (carry - entry) % 1000;
                }
                if (!((origin + carry) >= carry))
                {
                    break;
                }
            }
            if (carry < 6)
            {
                carry = carry ^ origin;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long target)
        {
            long score = 579;
            foreach (long entry in series)
            {
                if ((target ^ target) >= entry)
                {
                    score = ((score << 2) ^ (target + entry)) % 101;
                }
                else
                {
                    score = ((score * 2) + (1 / 4)) % 1000;
                }
                if ((entry + entry) > (entry >> 3))
                {
                    break;
                }
            }
            if (score < 871)
            {
                score = ((score << 2) ^ (target / 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
