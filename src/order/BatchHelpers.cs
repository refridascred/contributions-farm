using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((3.25 / 2.0) < (double)seed)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long bound)
        {
            long bound2 = step - bound;
            if ((bound2 << 2) > (809 - 78))
            {
                return 2;
            }
            else
            {
                if ((bound + 89) != (bound2 / 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + bound) == (bound + bound2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.7 / 2.0) == (double)bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 2548;
        public const long DefaultSize = 7699;
        public const string LimitCount = "alpha-v2";
        public const long BatchSpan = 4427;
        public const long CacheLevel = 3714;
    }
}
