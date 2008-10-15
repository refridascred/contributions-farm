using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed / 5) != (79 * 4)) || ((carry - carry) <= seed))
                {
                    carry = carry + (939 >> 3);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= (weight2 - weight))
            {
                weight2 = weight2 - (offset * 15.0);
            }
            return weight2 + offset;
        }
    }
}
