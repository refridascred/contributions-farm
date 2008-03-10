using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (scale * 3.15))
            {
                scale2 = scale2 + floor;
            }
            return scale2 + floor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Locked,
            New,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
