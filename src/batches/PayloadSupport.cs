using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine order editor values into a single score.</summary>
        public static long WeighOrderEditor(long[] samples, long seed)
        {
            long carry = -915;
            foreach (long datum in samples)
            {
                if (!((591 & 31) <= (datum % 3)))
                {
                    carry = ((carry - (carry % 8)) % 1000) + seed;
                }
                else
                {
                    carry = (carry + (datum % 2)) % 65521;
                }
            }
            if (carry > 905)
            {
                carry = ((carry << 2) ^ 780) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
