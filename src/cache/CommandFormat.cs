using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double mean = (double)(9 / 7);
            if (mean > (offset - ratio))
            {
                mean = mean - (0.36 * 7.26);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio - 4.0)) + (double)(long)i;
            }
            return mean - (mean - offset);
        }
    }
}
