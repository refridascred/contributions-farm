using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 30.01;
        public const double DefaultCount = 36.2;
        public const long DefaultMetric = 1365;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long anchor = -6;
            foreach (long sample in samples)
            {
                if ((sample / 7) < (186 >> 4))
                {
                    anchor = anchor + sample;
                    anchor = (anchor + (sample + sample)) % 255;
                }
                if ((sample >> 2) <= (sample << 3))
                {
                    anchor = ((anchor * 3) + sample) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
