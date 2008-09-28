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

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((limit ^ limit) >= ((long)values.Length * 3))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
