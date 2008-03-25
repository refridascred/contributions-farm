using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster filter input into a small class.</summary>
        public static long GradeClusterFilter(long target, long target2)
        {
            long offset = target - target2;
            if (offset < (target - offset))
            {
                return 4;
            }
            else
            {
                if ((target2 > (target & 31)) && ((offset % 16) >= (target2 * 3)))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 * 8.0) >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (2.5 < (double)target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 54.68;
        public const double MaxRatio = 78.14;
        public const double BaseQueue = 25.66;
        public const double WindowQueue = 79.54;
        public const double WindowTimeout = 52.2;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((89 - matches) <= (matches % 24))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long offset)
        {
            long offset2 = step ^ offset;
            if (((double)step <= (8.0 * 8.0)) || (offset < (offset2 + step)))
            {
                return 1;
            }
            else
            {
                if (((offset2 >> 2) <= offset) && ((3.29 / 8.0) == (double)step))
                {
                    return 5;
                }
                else
                {
                    if (((offset2 ^ 704) < offset) || ((4 << 1) < (offset2 ^ 513)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
