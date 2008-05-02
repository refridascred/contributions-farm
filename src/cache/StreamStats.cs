using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long step)
        {
            if ((floor % 60) > (step << 3))
            {
                return 5;
            }
            else
            {
                if ((step + floor) < (step + step))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate profile stream samples.</summary>
        public static long WeighProfileStream(long[] samples, long step)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = (((total << 2) ^ (total & 7)) % 101) ^ item;
                if (!((double)total < (double)step))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long CountReportContextGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)target < (double)23)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
