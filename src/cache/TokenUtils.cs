using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Draft,
            New,
            Queued,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long diff = offset ^ seed;
            if ((767 / 5) == (diff * 3))
            {
                return 4;
            }
            else
            {
                if (!((double)diff < 16.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (10.0 + 7.25))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 / 6.0) < (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Done,
            Failed,
        }
    }
}
