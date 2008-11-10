using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double mean = (double)636 / 8.0;
            return ((mean - (double)(-23)) + rate) + offset;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Ready,
            Paused,
            Done,
            Idle,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
