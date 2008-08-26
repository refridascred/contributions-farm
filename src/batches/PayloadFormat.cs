using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Synced,
            Idle,
            New,
            Retry,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry << 2) ^ target;
                carry = carry ^ (long)i;
                if ((carry << 2) <= (target - target))
                {
                    carry = (carry - ((long)i - carry)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool VerifySchemaProfileRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Region { get; set; }
        }
    }
}
