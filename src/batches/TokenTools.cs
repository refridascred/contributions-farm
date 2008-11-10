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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
