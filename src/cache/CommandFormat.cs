using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a record context reading.</summary>
        public static double ScaleRecordContext(double bias, double bias2)
        {
            double drift = bias;
            if (drift > bias2)
            {
                drift = drift + (double)(-51);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)229) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count * 4) == (count - count))
                {
                    count = ((count + 1) ^ sample) - limit;
                }
            }
            return count;
        }
    }
}
