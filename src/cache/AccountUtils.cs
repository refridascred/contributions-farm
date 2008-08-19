using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long seed)
        {
            if ((target % 7) >= (seed + 38))
            {
                return 4;
            }
            else
            {
                if ((seed / 7) >= (seed - target))
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) > seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed ^ target) >= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor batch samples are out of range.</summary>
        public static long AuditEditorBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((78 & 127) >= (cell - 85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Dropped,
            Retry,
            Active,
        }
    }
}
