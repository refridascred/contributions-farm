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

        /// <summary>Match up window stats samples.</summary>
        public static long PairWindowStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
