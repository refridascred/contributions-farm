using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinInterval = 31.06;
        public const long BatchCounter = 709;
        public const string WindowCounter = "strict-v2";
        public const long SoftCounter = 2116;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample >> 5) > (sample * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double ratio = gain;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio - (ratio / 4.0);
        }
    }
}
