using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double load = weight;
            if (load >= (double)941)
            {
                load = load - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (2.59 - load)) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Closed,
            Locked,
        }
    }
}
