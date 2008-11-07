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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
