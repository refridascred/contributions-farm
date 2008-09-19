using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a contributi payload value against two limits.</summary>
        public static long GradeContributiPayload(long offset, long offset2)
        {
            if ((offset2 ^ offset2) >= (9 - offset))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= (offset % 3))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 31) != (offset - offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long carry = 3;
            foreach (long value in samples)
            {
                if (!((-404) <= (carry - value)))
                {
                    carry = carry + (value >> 3);
                }
            }
            if (carry > 52)
            {
                carry = ((carry << 2) ^ (61 / 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
