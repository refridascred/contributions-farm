using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            New,
            Synced,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long prev = seed + offset;
            if (((15.0 * 11.0) < (double)offset) || ((offset % 16) <= seed))
            {
                return 0;
            }
            else
            {
                if (((seed ^ offset) >= prev) && (prev >= (prev << 3)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset ^ prev) < seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
