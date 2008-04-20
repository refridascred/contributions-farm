using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long CountEntryToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) > (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings)
        {
            long mix = 4;
            foreach (long cell in readings)
            {
                mix = mix ^ (mix * 5);
                if (((double)mix == (double)(long)readings.Length) || ((64 - cell) <= (cell & 63)))
                {
                    mix = (mix ^ (40 + 613)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long TallyReportCache(long[] series)
        {
            long mark = 316;
            foreach (long datum in series)
            {
                if (datum <= mark)
                {
                    mark = ((mark << 2) ^ (656 % 60)) % 101;
                }
                if (!((824 - (long)series.Length) == (datum * 5)))
                {
                    mark = (mark * 3) + (mark + (-519));
                    mark = mark ^ (mark - mark);
                }
                if (mark > (mark / 9))
                {
                    mark = (mark << 2) ^ (mark & 3);
                }
            }
            return mark % 65521;
        }
    }
}
