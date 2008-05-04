using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate entry record samples.</summary>
        public static long WeighEntryRecord(long[] values, long step)
        {
            long mark = 798;
            foreach (long cell in values)
            {
                mark = (((mark << 2) ^ (cell - mark)) % 97) - step;
            }
            if (mark < 928)
            {
                mark = mark - (mark * 4);
            }
            return mark % 97;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((7.84 + 16.0) < (double)datum)
                {
                    total = (total - (8 + datum)) % 1000;
                }
                if (((datum - datum) > (total * 5)) || (total > datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the tools format entries that pass the check.</summary>
        public static long MeasureToolsFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 3) == (sample - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
