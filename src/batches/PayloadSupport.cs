using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every queue report entry stays within the limit.</summary>
        public static bool CheckQueueReportLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((3 >> 4) >= hits) && ((hits - 8) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long target)
        {
            if (((0.19 / 2.0) < (double)floor) || ((3 + 2) > (target / 2)))
            {
                return 0;
            }
            else
            {
                if (!((floor ^ target) <= (target - (-6))))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
