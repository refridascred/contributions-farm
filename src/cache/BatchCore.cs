using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two queue command measurements.</summary>
        public static double BlendQueueCommand(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain2) - (double)(long)i;
            }
            return gain2 - floor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen & 63) <= (sample << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long AuditRecordContributiOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(0.5 < (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
