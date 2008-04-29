using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long anchor = 889;
            foreach (long item in items)
            {
                anchor = anchor ^ ((-2) + item);
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (step << 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long total = 4;
            foreach (long item in values)
            {
                total = ((total << 2) ^ item) % 101;
                if ((item << 2) <= item)
                {
                    total = (total - item) % 101;
                }
            }
            return total;
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
