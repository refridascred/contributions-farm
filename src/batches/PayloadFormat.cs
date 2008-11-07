using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((13.0 + 8.0) <= (double)count)
                {
                    count = ((count + 1) + datum) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values)
        {
            long mix = 20;
            foreach (long value in values)
            {
                if ((563 * 5) <= (mix - mix))
                {
                    mix = (mix ^ (value + mix)) % 255;
                }
                else
                {
                    mix = ((mix * 5) + 741) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step != (3.68 + 14.0))
                {
                    continue;
                }
                else
                {
                    mark = mark + step;
                    mark = (mark * 3) + (mark / 9);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
