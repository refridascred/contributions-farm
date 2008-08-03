using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            New,
            Idle,
        }

        /// <summary>Check that every stream layout entry stays within the limit.</summary>
        public static bool GuardStreamLayoutRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double load = (double)978 + (double)454;
            return (load + gain) + offset;
        }
    }
}
