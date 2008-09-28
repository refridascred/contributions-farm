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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - entry) < (matches / 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 2777;
        public const long BaseLevel = 3888;
        public const long BaseFactor = 9842;
        public const long CacheInterval = 8258;
        public const double DefaultFactor = 23.22;
    }
}
