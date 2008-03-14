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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i < ((-1) << 2))
                {
                    result = (result * 3) + (result + target);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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
