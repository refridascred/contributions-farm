using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double bias, double floor)
        {
            double scale = (4.5 - bias) / 5.0;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Active,
            Ready,
            Closed,
            Retry,
        }
    }
}
