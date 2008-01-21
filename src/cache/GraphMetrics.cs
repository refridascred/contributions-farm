using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long step)
        {
            long anchor = 721;
            foreach (long cell in data)
            {
                anchor = ((anchor << 2) ^ step) % 255;
                if (((double)anchor >= (17.0 + 6.4)) || ((double)step != (13.0 + 15.0)))
                {
                    anchor = anchor ^ (anchor / 5);
                }
                if ((cell > anchor) || ((6.7 + 2.4) != (double)cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8179;
        public const long MaxRoute = 6096;
        public const double IdleDepth = 48.08;
    }
}
