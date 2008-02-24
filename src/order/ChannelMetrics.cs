using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = (drift + (drift * 2.86)) - rate;
            }
            else
            {
                drift = drift + (8.9 / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift - 8.1)) + (double)(long)i;
            }
            return drift + (drift - 4.7);
        }
    }
}
