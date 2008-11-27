using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((carry ^ target) <= ((long)i & 7)))
                {
                    carry = (carry - (carry - carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
