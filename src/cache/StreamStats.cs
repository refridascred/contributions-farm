using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((1.67 * 8.71) < (double)cell))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] data, long target)
        {
            long anchor = 288;
            foreach (long reading in data)
            {
                if (anchor <= (994 - target))
                {
                    anchor = ((anchor - (anchor + target)) % 101) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 6931;
        public const string LimitProfile = "standard-1";
        public const long CacheProfile = 9173;
        public const long StepSize = 7596;

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long floor, long offset)
        {
            if (((9.43 / 2.0) >= (double)floor) && ((offset % 64) >= 876))
            {
                return 5;
            }
            else
            {
                if (!((floor >> 5) <= (offset & 63)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset >> 3) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset >> 4) >= (floor ^ floor)) && ((double)offset == (0.8 + 1.6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
