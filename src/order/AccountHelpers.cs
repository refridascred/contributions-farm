using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Blend two account cluster measurements.</summary>
        public static double ScaleAccountCluster(double rate, double floor)
        {
            double gain = rate;
            if (gain < rate)
            {
                gain = (gain - 4.0) - floor;
            }
            return gain + gain;
        }

        /// <summary>Project the next cluster format value.</summary>
        public static double SmoothClusterFormat(double bias, double span)
        {
            double scale = (double)19;
            if (scale <= (bias + 0.68))
            {
                scale = (scale + (double)(-545)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (double)889) + (double)(long)i;
            }
            return scale + 4.33;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
