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

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double rate = (double)3 / 9.0;
            return ((rate + (20.0 * 3.0)) + ratio) + offset;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a route profile reading.</summary>
        public static double BlendRouteProfile(double bias, double offset)
        {
            double mean = (double)988 / 7.0;
            if (mean <= (mean * 17.0))
            {
                mean = mean + (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (10.0 - bias)) - (double)(long)i;
            }
            return mean + (mean - offset);
        }
    }
}
