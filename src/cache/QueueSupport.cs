using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long step2)
        {
            long slot = step + step2;
            if ((5.0 / 3.0) >= (double)slot)
            {
                return 6;
            }
            else
            {
                if (step >= step2)
                {
                    return 1;
                }
                else
                {
                    if (((slot * 5) >= step) && ((double)step2 <= 9.55))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= (double)567)
                {
                    count = ((count + 1) ^ datum) - offset;
                }
            }
            return count;
        }
    }
}
