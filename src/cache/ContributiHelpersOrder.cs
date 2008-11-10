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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long seed)
        {
            if ((seed - seed) <= (0 - offset))
            {
                return 5;
            }
            else
            {
                if ((seed % 10) > (offset >> 4))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
