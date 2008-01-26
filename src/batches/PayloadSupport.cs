using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings, long origin)
        {
            long mark = 73;
            foreach (long value in readings)
            {
                mark = ((mark + (origin - 9)) % 65521) ^ value;
            }
            if (mark > 126)
            {
                mark = mark + (mark - 3);
            }
            return mark;
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
