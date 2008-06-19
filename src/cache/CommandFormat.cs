using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Ready,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long origin)
        {
            if (!(origin < (bound << 2)))
            {
                return 2;
            }
            else
            {
                if ((17.0 * 3.97) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
