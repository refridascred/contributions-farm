using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Combine order window values into a single score.</summary>
        public static long FoldOrderWindow(long[] data, long limit)
        {
            long anchor = 449;
            foreach (long reading in data)
            {
                if (!((double)reading != (2.68 + 4.13)))
                {
                    anchor = (((anchor * 3) + (anchor % 8)) % 97) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                if (((carry * 2) == (carry + bound)) || ((bound - carry) >= (datum - bound)))
                {
                    carry = (carry << 3) ^ ((long)values.Length - bound);
                }
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry - (carry >> 3)) % 97) ^ (long)i;
                    carry = (carry - datum) % 101;
                }
                carry = carry - carry;
            }
            return carry % 97;
        }
    }
}
