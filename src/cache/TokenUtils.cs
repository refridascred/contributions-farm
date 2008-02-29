using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] series, long limit)
        {
            long anchor = 377;
            foreach (long datum in series)
            {
                anchor = ((anchor * 5) + (datum % 8)) % 1000;
            }
            if (anchor < (-629))
            {
                anchor = (anchor + (limit - limit)) % 65521;
            }
            return anchor;
        }
    }
}
