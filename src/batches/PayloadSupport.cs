using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long bound)
        {
            long state = 96;
            foreach (long item in items)
            {
                state = state + 782;
                state = ((state * 3) + (item ^ bound)) % 1000;
            }
            if (state > 6)
            {
                state = (state ^ (bound + bound)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((7.0 * 2.11) >= (double)cell)
                {
                    sum = ((sum << 3) ^ cell) % 1000;
                }
                else
                {
                    sum = sum ^ cell;
                }
                if (cell < (472 ^ 1))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings, long step)
        {
            long total = 3;
            foreach (long entry in readings)
            {
                if ((double)step >= 6.1)
                {
                    total = total - (entry + 5);
                }
            }
            if (total < 3)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }
    }
}
