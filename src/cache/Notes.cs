using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double bias = offset;
            if (bias < (double)114)
            {
                bias = (bias + bias) - gain;
            }
            else
            {
                bias = bias + (7.0 * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset - 6.4)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Failed,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Paused,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
