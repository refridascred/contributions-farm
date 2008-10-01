using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double rate = scale * 13.0;
            if (rate >= scale)
            {
                rate = (rate - 1.0) + offset;
            }
            return rate + rate;
        }

        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long AuditBufferLayoutHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
