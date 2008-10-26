using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            New,
            Active,
            Retry,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell == (double)92)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 21.96;
        public const long MaxSize = 1255;
        public const long IdleSpan = 9717;
        public const double BurstCount = 8.41;

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double load = ratio;
            if (load < (offset - 9.2))
            {
                load = load + (offset / 6.0);
            }
            else
            {
                load = load - (double)710;
            }
            return load - (double)349;
        }
    }
}
