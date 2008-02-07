using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((7.0 - 9.8) > (double)cell) && (bound > (count - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a channel stats counter forward.</summary>
        public static long SeriesChannelStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark << 2) ^ (offset + 7)) % 65521) - (long)i2;
                }
                if ((double)offset > (double)mark)
                {
                    mark = ((mark * 2) + mark) % 1000;
                }
                if (!(((1.83 / 6.0) > (double)(long)i) && ((offset % 60) > ((-484) & 63))))
                {
                    mark = mark + ((long)i & 255);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
