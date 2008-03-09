using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long mark = 249;
            foreach (long cell in levels)
            {
                if (!((double)cell == (1.0 + 6.6)))
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long WeighProfileToken(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if ((carry / 8) <= carry)
                {
                    carry = ((carry + (carry + carry)) % 101) - entry;
                }
                if (carry < (carry % 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
