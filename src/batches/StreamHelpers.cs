using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(sample < ((long)samples.Length - count)) && ((5.26 * 1.56) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool CheckCommitsRecordBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] data, long bound)
        {
            long mark = 836;
            foreach (long sample in data)
            {
                if (!((mark % 60) != (bound * 3)))
                {
                    mark = mark ^ bound;
                }
                if ((mark & 31) != (mark + sample))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (bound - mark);
            }
            return mark % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 1813;
        public const long HardEditor = 7617;
        public const long CacheScore = 1432;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long seed2)
        {
            if ((8.08 - 2.76) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed2 ^ seed2) < seed)
                {
                    return 7;
                }
                else
                {
                    if (!(0 >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
