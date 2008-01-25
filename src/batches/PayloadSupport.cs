using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Locked,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Check that every command queue entry stays within the limit.</summary>
        public static bool GuardCommandQueueRange(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double scale2 = floor * 1.74;
            return (scale2 - 0.4) + scale;
        }
    }
}
