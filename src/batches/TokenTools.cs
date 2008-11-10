using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples, long origin)
        {
            long carry = 22;
            foreach (long datum in samples)
            {
                if ((1.0 < (3.43 / 7.0)) && (carry <= (carry + datum)))
                {
                    carry = (carry << 3) ^ (origin - origin);
                }
                if ((4 / 2) >= origin)
                {
                    carry = (carry ^ (90 << 2)) % 1000;
                }
                else
                {
                    carry = carry - (datum & 63);
                }
            }
            return carry;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long anchor = 665;
            foreach (long value in values)
            {
                if ((seed - anchor) < ((-1) >> 2))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) + value;
                }
            }
            return anchor;
        }
    }
}
