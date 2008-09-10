using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long limit)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                if (((4 ^ 379) == (limit >> 1)) && (limit > (limit << 2)))
                {
                    mark = mark - (mark >> 5);
                }
                if ((datum * 5) == (mark - limit))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool GuardNotesCacheRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of githubfarm tools readings.</summary>
        public static long DigestGithubfarmTools(long[] readings)
        {
            long carry = -4;
            foreach (long item in readings)
            {
                carry = ((carry * 5) + (154 - carry)) % 65521;
                if ((item + 930) < 495)
                {
                    carry = carry ^ carry;
                }
            }
            if (carry < (-61))
            {
                carry = ((carry * 2) + carry) % 97;
            }
            return carry;
        }
    }
}
