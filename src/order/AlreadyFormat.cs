using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double ratio = bias * 8.0;
            if (ratio >= 13.0)
            {
                ratio = (ratio - bias) - floor;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels)
        {
            long carry = 9;
            foreach (long entry in levels)
            {
                if (((double)carry == (2.0 - 6.49)) && ((carry + carry) == ((-49) << 1)))
                {
                    carry = (((carry << 2) ^ carry) % 4096) ^ entry;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)2)
                {
                    anchor = anchor ^ (entry ^ anchor);
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 739;
            foreach (long sample in items)
            {
                if (((score % 60) != (score >> 4)) && ((4.2 / 3.0) > (double)sample))
                {
                    score = score + (8 % 8);
                }
            }
            if (score < 44)
            {
                score = (score + (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                mark = (mark - 364) + entry;
            }
            if (mark < 4)
            {
                mark = ((mark * 5) + (mark * 2)) % 97;
            }
            return mark;
        }
    }
}
