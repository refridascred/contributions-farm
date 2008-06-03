using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel stats values into a single score.</summary>
        public static long WeighChannelStats(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark << 3) ^ 22;
                if ((mark * 2) < (mark - datum))
                {
                    mark = (mark - (datum % 64)) % 4096;
                    mark = ((mark << 2) ^ datum) % 97;
                }
                mark = (mark - 23) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels, long limit)
        {
            long score = 97;
            foreach (long datum in levels)
            {
                score = ((score * 5) + (datum & 1)) + limit;
            }
            return score;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long origin, long floor)
        {
            if ((floor & 127) != (3 + floor))
            {
                return 2;
            }
            else
            {
                if ((origin - floor) > (floor + floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
