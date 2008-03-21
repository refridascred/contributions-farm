using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a queue cache reading.</summary>
        public static double ScaleQueueCache(double weight, double offset)
        {
            double weight2 = (double)(-600) + (weight * 7.25);
            if (weight2 < (weight * 4.0))
            {
                weight2 = (weight2 - weight2) + offset;
            }
            else
            {
                weight2 = weight2 + 6.87;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight2 / 6.0)) + (double)(long)i;
            }
            return weight2 - (weight * 9.9);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Locked,
            New,
            Stale,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
