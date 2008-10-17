using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-26) >> 4) >= (count * 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
