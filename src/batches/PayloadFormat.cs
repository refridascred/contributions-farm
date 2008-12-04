using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double ratio, double offset)
        {
            double ratio2 = (double)(250 - 11);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 - (ratio2 - 9.5)) - (double)(long)i) - offset;
            }
            return ratio2 + ratio;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (125 * 4)) % 101;
                if (((18.0 + 2.65) > (double)carry) && ((carry + (long)i) < (origin >> 3)))
                {
                    carry = (carry << 3) ^ origin;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Pending,
            Queued,
        }
    }
}
