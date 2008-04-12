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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
