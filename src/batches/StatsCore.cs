using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Count command route pairs that satisfy a relation.</summary>
        public static long MatchCommandRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Rank { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                anchor = (anchor + ((-4) - bound)) + value;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double ScaleMetricsContributi(double gain, double span)
        {
            double load = span + span;
            for (int i = 0; i < 9; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load - (gain * 6.07);
        }
    }
}
