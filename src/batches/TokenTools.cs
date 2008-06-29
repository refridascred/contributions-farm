using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleLevel = 6917;
        public const long WindowScore = 9546;
        public const long CacheWidth = 546;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((2.7 / 3.0) < (double)anchor))
                {
                    anchor = ((anchor << 2) ^ (target + anchor)) % 1000;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ (1 ^ target)) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
