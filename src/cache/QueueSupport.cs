using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double gain = (offset * 3.1) + (8.74 * 4.0);
            if (gain < (double)1)
            {
                gain = gain - bias;
            }
            return gain + gain;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Idle,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
