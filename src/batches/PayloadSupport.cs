using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftLevel = 4434;
        public const long WindowRatio = 8773;
        public const string HardCluster = "standard-1";

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long carry = 22;
            foreach (long reading in samples)
            {
                carry = (carry + (reading * 2)) % 1000;
                if ((carry / 9) >= (carry + reading))
                {
                    carry = (carry + ((-86) - reading)) % 65521;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
                carry = (carry + (reading & 15)) % 65521;
                if ((reading * 5) < 421)
                {
                    break;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 4) + (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
