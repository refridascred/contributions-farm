using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double rate = floor;
            if (rate <= floor)
            {
                rate = rate - (double)26;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
