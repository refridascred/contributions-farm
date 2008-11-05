using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Done,
            Draft,
            Failed,
            Ready,
        }
    }
}
