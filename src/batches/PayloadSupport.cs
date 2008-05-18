using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstLevel = 48.02;
        public const long IdleFactor = 643;
        public const double BurstWidth = 53.69;
        public const long SoftChannel = 6814;
        public const double BatchSpan = 98.65;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a graph channel counter forward.</summary>
        public static long DeriveGraphChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step + step) <= (long)i)
                {
                    carry = ((carry * 2) + (step - carry)) % 97;
                }
                carry = carry ^ (step >> 3);
                carry = (carry ^ (carry << 3)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
