using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long limit)
        {
            long score = 7;
            foreach (long entry in series)
            {
                score = ((score + (score + score)) % 4096) ^ entry;
                score = (score * 5) + 99;
            }
            if (score > 341)
            {
                score = score - (limit * 2);
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if ((item & 15) > (mark * 2))
                {
                    mark = (mark - (mark - 3)) % 255;
                }
                else
                {
                    mark = (mark ^ item) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((3.0 / 2.0) <= (double)sum)
                {
                    sum = (sum ^ (long)i) % 255;
                }
                else
                {
                    sum = (sum - floor) % 4096;
                }
                if ((sum % 10) > (sum * 5))
                {
                    sum = ((sum << 2) ^ (sum & 31)) % 255;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum - ((long)i >> 3)) % 4096) ^ (long)i2;
                    sum = ((sum * 2) + (floor + (-373))) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
