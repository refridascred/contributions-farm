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

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long seed, long bound)
        {
            if (!((0.7 * 9.0) >= (double)bound))
            {
                return 8;
            }
            else
            {
                if (3 > (bound * 4))
                {
                    return 0;
                }
                else
                {
                    if (!(9 < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
