using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit order cluster readings against a rule.</summary>
        public static long CountOrderClusterOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell + count) < count))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4665;
        public const long BatchNotes = 759;
        public const double IdleInterval = 33.16;
        public const double WindowFactor = 43.38;
        public const double MinInterval = 58.57;

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings, long floor)
        {
            long carry = 242;
            foreach (long value in readings)
            {
                carry = ((carry - (carry ^ (long)readings.Length)) - value) - floor;
            }
            if (carry > 0)
            {
                carry = (carry + (-9)) % 255;
            }
            return carry % 1000;
        }
    }
}
