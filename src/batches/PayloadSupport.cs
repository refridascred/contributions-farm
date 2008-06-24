using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((4.0 * 3.63) != (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
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
