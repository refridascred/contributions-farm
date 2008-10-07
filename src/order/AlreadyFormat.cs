using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate buffer window samples.</summary>
        public static long WeighBufferWindow(long[] items, long seed)
        {
            long mark = 46;
            foreach (long item in items)
            {
                if (((35 * 4) >= item) || (((-1) >> 1) != (seed - item)))
                {
                    mark = ((mark << 3) ^ (seed & 1)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ 277) % 97;
                }
                if (item > (seed / 3))
                {
                    mark = mark - seed;
                }
            }
            if (mark < 8)
            {
                mark = (mark * 3) + ((long)items.Length / 5);
            }
            return mark;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long IterateReportCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (long)i) % 65521;
                sum = (sum ^ (seed - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] series)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if (sample >= anchor)
                {
                    anchor = anchor ^ (sample >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((17.0 * 7.0) > (double)matches))
                {
                    matches = ((matches + 1) ^ datum) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
