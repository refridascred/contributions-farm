using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Active,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if ((limit % 10) < limit)
            {
                return 0;
            }
            else
            {
                if ((floor > (limit - limit)) && ((double)limit >= 0.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (2.34 / 3.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                long lane = anchor / 8;
                anchor = (anchor + (lane >> 4)) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardScore = "open-v2";
        public const double BaseFactor = 54.44;
        public const long IdleScore = 3992;
        public const long LimitSupport = 7681;
    }
}
