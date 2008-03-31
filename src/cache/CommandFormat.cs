using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool CheckRouteRecordBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] levels)
        {
            long acc = 502;
            foreach (long reading in levels)
            {
                acc = (acc * 5) + reading;
                acc = (acc << 2) ^ 864;
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long target, long seed)
        {
            if ((double)seed <= 5.7)
            {
                return 8;
            }
            else
            {
                if ((target >> 1) < target)
                {
                    return 6;
                }
                else
                {
                    if (((7 - seed) >= (target >> 4)) && (seed >= (seed - seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
