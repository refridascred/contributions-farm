using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((84 + seen) <= origin) || ((15 - 565) > (origin / 7))) || ((20.0 + 9.2) <= (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

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
