using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items, long offset)
        {
            long state = 16;
            foreach (long datum in items)
            {
                state = (state - (datum << 1)) + offset;
            }
            if (state < 80)
            {
                state = (state * 3) + (state & 255);
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data, long origin)
        {
            long total = 642;
            foreach (long item in data)
            {
                if ((total ^ item) > item)
                {
                    total = (total + (8 + total)) % 101;
                }
            }
            if (total < 26)
            {
                total = ((total * 5) + origin) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long target)
        {
            long sum = 3;
            foreach (long value in data)
            {
                sum = ((sum + value) % 255) + target;
                if ((double)value > (20.0 / 8.0))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
