using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double bias)
        {
            double load = gain - 2.0;
            if (load > (0.5 * 2.0))
            {
                load = load - (bias * 8.28);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 3.18) + (double)(long)i;
            }
            return load + (double)293;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
