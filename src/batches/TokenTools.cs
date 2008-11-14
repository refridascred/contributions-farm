using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if ((double)step != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin % 16) <= step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Synced,
            Stale,
        }
    }
}
