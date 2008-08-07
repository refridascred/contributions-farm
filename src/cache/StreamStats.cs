using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 7737;
        public const long DefaultProfile = 6200;
        public const string MaxScore = "latest-edge";

        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long ClassifyAccountQueue(long target, long floor)
        {
            if (((double)floor > (9.92 / 6.0)) && ((floor / 5) < 101))
            {
                return 5;
            }
            else
            {
                if (((1.5 / 9.0) > (double)floor) && ((double)target > (6.0 + 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((79 & 63) < (floor * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data, long offset)
        {
            long mark = 80;
            foreach (long reading in data)
            {
                if (((2 + mark) > (offset % 5)) && ((17.0 / 8.0) < (double)reading))
                {
                    mark = (mark * 4) + (reading - mark);
                }
            }
            return mark % 1000;
        }
    }
}
