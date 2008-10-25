using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long target, long limit)
        {
            if (((limit & 127) <= limit) && (target <= (target << 3)))
            {
                return 4;
            }
            else
            {
                if ((target * 5) > (-70))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 + 12.0) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target - target) >= (limit * 5)) && (target <= limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (8 > (matches - matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long target)
        {
            if ((offset < (91 >> 5)) || (offset <= target))
            {
                return 6;
            }
            else
            {
                if ((offset <= (78 + target)) && ((9 + offset) > (894 - target)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((867 % 5) == (matches + matches)) || ((double)(long)samples.Length <= (3.0 + 4.57)))
                {
                    matches = ((matches + 1) + value) + floor;
                }
            }
            return matches;
        }
    }
}
