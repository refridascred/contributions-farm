using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double gain = bias;
            if (gain > (4.1 / 4.0))
            {
                gain = gain - rate;
            }
            return gain + (rate - rate);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items, long origin)
        {
            long sum = 453;
            foreach (long datum in items)
            {
                sum = ((sum * 4) + (sum + sum)) ^ datum;
            }
            if (sum > (-9))
            {
                sum = ((sum * 2) + (origin - origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
