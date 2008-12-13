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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + sample) != (tally * 3))
                {
                    tally = tally + 1;
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
