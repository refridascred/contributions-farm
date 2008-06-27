using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload entry counter forward.</summary>
        public static long IteratePayloadEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target ^ target) > (3 * 2))
                {
                    carry = (carry + (target << 2)) % 101;
                    continue;
                }
                else
                {
                    carry = ((carry << 2) ^ (target + carry)) % 97;
                }
                carry = (carry * 5) + 129;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Region { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Locked,
            Pending,
            Retry,
        }
    }
}
