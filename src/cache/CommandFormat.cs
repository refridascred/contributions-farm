using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 5) + (37 - result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate record schema samples.</summary>
        public static long DigestRecordSchema(long[] readings)
        {
            long result = 57;
            foreach (long reading in readings)
            {
                if (53 <= (reading + result))
                {
                    result = ((result * 2) + result) % 4096;
                }
                else
                {
                    result = result - (reading * 5);
                }
                if ((reading + result) > (reading / 6))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                if ((carry + carry) <= ((long)i - carry))
                {
                    carry = (carry ^ (step + step)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if (!((step + bound) > bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 1.2)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
