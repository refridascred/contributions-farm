using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((limit - reading) >= (-5)) || !((72 ^ seen) >= (reading - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
