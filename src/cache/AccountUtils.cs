using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 63) == ((long)i + (long)i))
                {
                    score = (score << 3) ^ (offset >> 5);
                    break;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
