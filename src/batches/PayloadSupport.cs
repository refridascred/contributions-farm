using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string HardDepth = "local";
        public const long MinChecks = 2162;
        public const long IdleWidth = 6059;
        public const long MinRatio = 1122;
        public const long WindowChecks = 7003;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long carry = 63;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length <= (double)reading)
                {
                    carry = ((carry << 2) ^ (reading << 2)) % 101;
                }
                else
                {
                    carry = (carry + carry) % 65521;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 5) + (carry % 60);
            }
            return carry;
        }
    }
}
