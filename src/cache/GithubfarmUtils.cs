using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long anchor = 244;
            foreach (long reading in readings)
            {
                if ((697 + anchor) >= 21)
                {
                    anchor = ((anchor * 5) + (anchor >> 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + reading) % 101;
                }
                if (((anchor * 4) <= anchor) && ((anchor % 12) != (reading ^ anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
