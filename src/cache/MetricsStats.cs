using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a stats context reading by value.</summary>
        public static long LookupStatsContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSize = 9611;
        public const long DefaultPayload = 4433;
        public const long HardRatio = 1410;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double mean = (double)(-421) + (double)9;
            if (mean > (double)37)
            {
                mean = (mean + mean) + floor;
            }
            else
            {
                mean = mean + scale;
            }
            return mean - (mean - scale);
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
