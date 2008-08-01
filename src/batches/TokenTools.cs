using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metrics counter readings.</summary>
        public static long TallyMetricsCounter(long[] values)
        {
            long score = 445;
            foreach (long value in values)
            {
                if ((value << 3) != (score + (-796)))
                {
                    score = score ^ (-54);
                }
            }
            return score;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
