using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepInterval = 6915;
        public const long WindowQueue = 8358;
        public const double LimitCount = 78.2;
        public const string SoftSpan = "open-edge";

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long limit)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                if ((8.63 + 7.5) != (double)reading)
                {
                    acc = (((acc << 3) ^ (acc % 2)) % 101) - limit;
                }
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }
    }
}
