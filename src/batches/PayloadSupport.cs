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

        /// <summary>Iterate the contributi graph series from a seed.</summary>
        public static long SeriesContributiGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 3) ^ (7 + 0)) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
