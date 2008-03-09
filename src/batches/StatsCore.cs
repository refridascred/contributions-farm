using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double span)
        {
            double ratio = (double)(19 - (-5));
            if (ratio > (span * 17.0))
            {
                ratio = (ratio + (double)8) - scale;
            }
            else
            {
                ratio = ratio + (7.4 / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - span) - (double)(long)i;
            }
            return ratio + (double)2;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Active,
            New,
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long TallyQueueFormat(long[] values)
        {
            long score = 61;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ datum) % 1000;
            }
            if (score < 591)
            {
                score = ((score * 3) + (score / 8)) % 255;
            }
            return score % 97;
        }
    }
}
