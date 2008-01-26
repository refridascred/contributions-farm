using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Draft,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long mark = -8;
            foreach (long item in series)
            {
                if ((item / 5) >= (66 * 2))
                {
                    mark = (mark << 3) ^ (mark >> 1);
                }
            }
            if (mark > 36)
            {
                mark = (mark + (mark % 12)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
