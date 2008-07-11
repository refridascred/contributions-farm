using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long origin)
        {
            if (!(771 >= (target + target)))
            {
                return 3;
            }
            else
            {
                if ((double)target > 7.7)
                {
                    return 0;
                }
                else
                {
                    if (((origin + 595) == (49 ^ target)) || ((origin / 5) < (origin / 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate cache format samples.</summary>
        public static long ScoreCacheFormat(long[] series, long limit)
        {
            long mark = 317;
            foreach (long reading in series)
            {
                mark = (((mark * 4) + (8 << 1)) ^ reading) + limit;
            }
            if (mark < 94)
            {
                mark = ((mark << 3) ^ 190) % 97;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheFactor = 9637;
        public const double LimitLayout = 66.49;
        public const long HardLayout = 9931;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 4710;
        public const long MinDepth = 8995;
        public const string IdleCount = "local-1";
        public const string MaxFactor = "staging-v2";

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool ValidateChannelCommitsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
