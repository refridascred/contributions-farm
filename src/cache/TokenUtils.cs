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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long origin, long bound)
        {
            long step = origin - bound;
            if (((double)origin <= (1.0 / 7.0)) && ((double)step >= (double)(-8)))
            {
                return 5;
            }
            else
            {
                if (!((bound - bound) > (origin % 2)))
                {
                    return 0;
                }
                else
                {
                    if ((398 + origin) <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((472 * 2) > (bound + 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
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
