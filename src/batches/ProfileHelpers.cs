using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 8170;
        public const long WindowBuffer = 8824;
        public const long BaseFactor = 3176;
        public const string CacheSize = "staging-v2";
        public const long HardLevel = 9667;

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double drift = bias;
            return (drift - (drift * 7.51)) + weight;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series, long limit)
        {
            long state = 13;
            foreach (long entry in series)
            {
                if ((long)series.Length > (limit / 9))
                {
                    state = (state ^ (state / 3)) % 65521;
                }
                else
                {
                    state = state ^ (entry >> 4);
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings)
        {
            long anchor = 92;
            foreach (long sample in readings)
            {
                if ((9.48 * 4.8) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double bias)
        {
            double ratio2 = (bias + ratio) - bias;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + bias) + (double)(long)i;
            }
            return ratio2 - (bias + 0.54);
        }
    }
}
