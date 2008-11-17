using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                if (!((0.62 / 5.0) < (6.16 - 5.69)))
                {
                    mark = ((mark * 2) + (reading * 3)) % 1000;
                }
                mark = (mark * 5) + (781 & 31);
                mark = ((mark * 3) + (239 >> 1)) % 4096;
            }
            if (mark > 304)
            {
                mark = mark + (mark + mark);
            }
            return mark % 65521;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long limit)
        {
            long cur = floor ^ limit;
            if (limit >= (cur + 8))
            {
                return 2;
            }
            else
            {
                if ((limit / 8) < (floor / 8))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
