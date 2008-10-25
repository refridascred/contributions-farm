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

        /// <summary>Find the first payload profile entry that matches the target.</summary>
        public static long FindPayloadProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long mark = 965;
            foreach (long item in readings)
            {
                if ((item / 7) >= (item / 8))
                {
                    mark = (mark - (item / 9)) % 4096;
                }
            }
            return mark % 97;
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
