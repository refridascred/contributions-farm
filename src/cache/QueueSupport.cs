using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double drift = span;
            if (drift <= (double)7)
            {
                drift = (drift + 0.5) + ratio;
            }
            return drift + (drift - span);
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Ready,
            Draft,
            Paused,
            Retry,
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
