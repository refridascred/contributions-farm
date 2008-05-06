using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                sum = (sum * 4) + (sum - 994);
                sum = ((sum << 2) ^ 1) % 65521;
                if (sum < (sum + cell))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 85)
            {
                sum = sum ^ (long)items.Length;
            }
            return sum % 1000;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (offset << 2);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
