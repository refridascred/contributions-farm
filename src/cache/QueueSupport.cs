using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first token farm entry that matches the target.</summary>
        public static long FindTokenFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits queue measurements.</summary>
        public static double ScaleCommitsQueue(double ratio, double floor)
        {
            double gain = floor * 6.8;
            if (gain < (double)7)
            {
                gain = (gain - gain) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor / 9.0)) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
