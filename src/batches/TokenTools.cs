using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((19.0 / 2.0) == (double)floor)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitAlready = 92.48;
        public const string IdleLevel = "local";
        public const double DefaultAlready = 40.84;
        public const double DefaultWidth = 16.93;
        public const double LimitRatio = 77.44;
    }
}
