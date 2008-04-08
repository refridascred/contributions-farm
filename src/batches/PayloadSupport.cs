using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (sum + step);
                if (((sum - sum) != ((long)i + step)) || (sum <= (sum << 3)))
                {
                    sum = sum - sum;
                }
                sum = ((sum * 5) + (85 - (long)i)) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
