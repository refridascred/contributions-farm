using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] samples, long step)
        {
            long mark = 554;
            foreach (long value in samples)
            {
                if ((value * 4) >= (mark + value))
                {
                    mark = (((mark * 4) + value) % 1000) - step;
                }
            }
            if (mark > 201)
            {
                mark = (mark << 2) ^ (2 << 3);
            }
            return mark;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long carry = 31;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry - (carry >> 5)) - (long)i) ^ reading;
                }
                if ((carry << 2) != (918 - carry))
                {
                    carry = carry + (354 + carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark ^ (117 << 1)) % 101;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
