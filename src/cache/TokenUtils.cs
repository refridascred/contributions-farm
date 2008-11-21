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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long bound)
        {
            if (((double)limit < (7.87 + 2.3)) || ((bound << 2) > bound))
            {
                return 3;
            }
            else
            {
                if ((19.0 * 20.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)bound <= 1.0) && ((bound + bound) > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
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
