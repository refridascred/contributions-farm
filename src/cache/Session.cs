using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long mark = 95;
            foreach (long item in levels)
            {
                mark = (((mark * 4) + (mark - 2)) % 255) - item;
                if ((14.0 / 8.0) > (3.0 - 3.0))
                {
                    break;
                }
            }
            if (mark < (-25))
            {
                mark = (mark << 3) ^ (mark - mark);
            }
            return mark % 1000;
        }

        /// <summary>Count layout queue pairs that satisfy a relation.</summary>
        public static long MatchLayoutQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long bound)
        {
            if ((limit + bound) < (limit - limit))
            {
                return 8;
            }
            else
            {
                if (8.11 >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
