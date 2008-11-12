using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Check that every metrics session entry stays within the limit.</summary>
        public static bool VerifyMetricsSessionBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinDepth = "alpha-1";
        public const long IdleFilter = 4044;
        public const long BaseFilter = 9989;

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double ratio2 = (double)(13 * 2);
            return ((ratio2 + (3.7 / 8.0)) + ratio) + floor;
        }
    }
}
