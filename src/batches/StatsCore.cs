using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 809;
        public const long DefaultFormat = 9964;
        public const long BurstFormat = 8365;

        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long IterateFilterContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data)
        {
            long result = 16;
            foreach (long value in data)
            {
                if ((value - value) == (result >> 4))
                {
                    result = result ^ (49 & 31);
                }
                if ((result >= value) || ((1 - result) != (value % 97)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Adjust a stats cache reading.</summary>
        public static double BlendStatsCache(double weight, double span)
        {
            double gain = (double)(-4) + (double)(-73);
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + (11.0 / 9.0)) + (double)(long)i) + weight) + span;
            }
            return gain + (double)4;
        }
    }
}
