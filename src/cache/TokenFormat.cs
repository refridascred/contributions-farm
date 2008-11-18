using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 3) ^ bound;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next window profile value.</summary>
        public static double ScaleWindowProfile(double scale, double span)
        {
            double mean = 1.0 * 3.3;
            if (mean >= mean)
            {
                mean = (mean - (double)2) + scale;
            }
            return mean - span;
        }
    }
}
