using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry & 3) == (seen + target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 375;
            foreach (long sample in data)
            {
                if (((mark << 2) <= (offset << 2)) || ((double)sample <= 9.87))
                {
                    mark = (mark ^ (offset - offset)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long floor, long limit)
        {
            if ((limit ^ floor) > (limit - floor))
            {
                return 5;
            }
            else
            {
                if (((floor + floor) < limit) && ((limit / 6) == (limit + 634)))
                {
                    return 1;
                }
                else
                {
                    if ((20.0 / 2.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + floor) != (64 * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
