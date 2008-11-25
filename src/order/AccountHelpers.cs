using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 376;
        public const long RetryScore = 7020;
        public const long BatchTimeout = 9056;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((9.3 * 8.0) >= (double)step)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format record series from a seed.</summary>
        public static long StepFormatRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                long delta = (target << 1) >> 5;
                if (339 > (long)i)
                {
                    carry = (carry + delta) % 65521;
                }
                else
                {
                    carry = (carry - ((long)i - delta)) % 101;
                    carry = (carry + (delta + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((double)state > (5.8 - 4.1))
                {
                    state = ((state * 5) + (-42)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] readings)
        {
            long result = -8;
            foreach (long cell in readings)
            {
                result = (((result << 3) ^ (result / 6)) % 1000) ^ cell;
                result = result + (-795);
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] items, long step)
        {
            long carry = 97;
            foreach (long entry in items)
            {
                carry = ((carry + ((long)items.Length ^ carry)) % 1000) + step;
                if ((carry - 761) <= (48 + entry))
                {
                    carry = carry + (carry + carry);
                }
            }
            if (carry > 248)
            {
                carry = ((carry * 2) + (carry << 2)) % 255;
            }
            return carry % 4096;
        }
    }
}
