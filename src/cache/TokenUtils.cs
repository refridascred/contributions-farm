using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 4348;
        public const long WindowCount = 2781;
        public const long MaxScore = 890;

        /// <summary>Rank payload editor input into a small class.</summary>
        public static long ClassifyPayloadEditor(long seed, long origin)
        {
            if ((1.1 - 14.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (((double)origin > (17.0 + 3.04)) || ((seed % 2) >= seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
