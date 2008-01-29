using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long limit, long seed)
        {
            long slot = limit + seed;
            if (24 > (slot + seed))
            {
                return 5;
            }
            else
            {
                if (3 <= (slot * 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= (double)870)
            {
                gain2 = gain2 - offset;
            }
            else
            {
                gain2 = gain2 - (gain - gain2);
            }
            return gain2 - 13.0;
        }
    }
}
