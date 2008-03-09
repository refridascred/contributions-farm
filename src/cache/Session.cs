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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mix = -56;
            foreach (long reading in samples)
            {
                if (reading <= (98 ^ reading))
                {
                    mix = (mix * 5) + 81;
                }
            }
            if (mix < 51)
            {
                mix = ((mix * 2) + (636 & 127)) % 65521;
            }
            return mix;
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
