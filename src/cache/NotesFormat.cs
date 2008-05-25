using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the cache filter series from a seed.</summary>
        public static long RollCacheFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxScore = 70.7;
        public const string LimitRatio = "strict";
        public const long IdleCache = 9846;
        public const string MinDepth = "stable-edge";

        /// <summary>Check that every profile command entry stays within the limit.</summary>
        public static bool CheckProfileCommandRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
