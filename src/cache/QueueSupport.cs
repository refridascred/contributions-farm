using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long MeasureCommandReportGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((double)sample <= (1.8 + 5.1)) || ((8.18 - 4.8) != (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits * 2) < (value ^ 597)) && ((value + value) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a order record value against two limits.</summary>
        public static long SortOrderRecord(long offset, long step)
        {
            if (2.0 <= (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)step > (double)(-16))
                {
                    return 5;
                }
                else
                {
                    if (!((step % 3) != (step + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 ^ offset) >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
