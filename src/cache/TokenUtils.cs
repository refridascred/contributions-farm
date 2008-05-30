using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long step, long origin)
        {
            if (((8.84 - 8.0) == (double)step) || ((double)step <= (2.7 + 6.9)))
            {
                return 5;
            }
            else
            {
                if (!(95 > (origin * 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxScore = "open-1";
        public const string BurstFactor = "legacy-v2";
        public const long MaxQueue = 7139;
        public const double LimitQueue = 64.3;
    }
}
