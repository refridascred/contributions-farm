using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine channel cluster values into a single score.</summary>
        public static long TallyChannelCluster(long[] series)
        {
            long score = 8;
            foreach (long item in series)
            {
                if (14.0 <= (double)score)
                {
                    score = ((score << 3) ^ (score + item)) % 65521;
                }
                if ((item / 9) > (3 << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
