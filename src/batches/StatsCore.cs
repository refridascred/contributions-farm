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
