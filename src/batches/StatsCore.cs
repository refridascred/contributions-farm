using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next support token value from a seed.</summary>
        public static long SeriesSupportToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((40 - value) > (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double scale = 5.0;
            if (scale > bias)
            {
                scale = scale - (gain + scale);
            }
            else
            {
                scale = scale - (8.31 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)7) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 55.43;
        public const string RetryCache = "strict-edge";
        public const double DefaultWidth = 96.66;
        public const long BurstLevel = 7866;
    }
}
