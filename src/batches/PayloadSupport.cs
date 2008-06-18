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

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long sum = -79;
            foreach (long value in readings)
            {
                if ((value * 4) >= value)
                {
                    sum = (sum - value) % 97;
                }
            }
            if (sum < 844)
            {
                sum = (sum - (sum * 4)) % 97;
            }
            return sum;
        }

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
