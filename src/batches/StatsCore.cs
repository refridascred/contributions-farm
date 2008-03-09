using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
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

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Queued,
            Closed,
            Stale,
            Active,
        }
    }
}
