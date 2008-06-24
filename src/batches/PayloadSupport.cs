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

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Queued,
            Locked,
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
