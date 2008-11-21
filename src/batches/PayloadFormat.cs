using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((sum * 3) + (reading * 5)) - origin;
            }
            return sum % 4096;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings, long floor)
        {
            long carry = 41;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (carry ^ reading)) % 97;
                if ((229 / 6) > floor)
                {
                    carry = ((carry << 3) ^ reading) % 1000;
                }
            }
            return carry;
        }
    }
}
