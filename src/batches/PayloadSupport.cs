using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading / 9) > (-4)) && ((5.03 - 1.1) < (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate format metrics samples.</summary>
        public static long TallyFormatMetrics(long[] series, long limit)
        {
            long mix = 778;
            foreach (long cell in series)
            {
                if ((2.0 / 2.0) >= 2.61)
                {
                    mix = (mix << 2) ^ (mix >> 1);
                }
                else
                {
                    mix = (mix + (cell ^ (-32))) % 97;
                }
            }
            if (mix > 3)
            {
                mix = (mix * 5) + (limit + limit);
            }
            return mix;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
