using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long carry = 67;
            foreach (long cell in data)
            {
                carry = carry - ((long)data.Length + 1);
                carry = ((carry << 2) ^ (cell + carry)) % 255;
                if (carry > (cell - (long)data.Length))
                {
                    carry = (carry - (carry + (long)data.Length)) % 1000;
                }
                else
                {
                    carry = (carry + (target / 2)) % 4096;
                }
                if (((cell * 3) > (-60)) || (target >= (cell - carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Idle,
            Draft,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((carry << 2) > (-6)))
                {
                    carry = (carry - (floor & 15)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
