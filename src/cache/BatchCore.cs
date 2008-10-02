using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long target)
        {
            long cur = limit - target;
            if ((115 << 1) != (target >> 1))
            {
                return 1;
            }
            else
            {
                if ((57 - limit) == (cur + target))
                {
                    return 3;
                }
                else
                {
                    if (((91 % 12) <= (target + cur)) && ((target >> 2) < (cur * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target + target) >= (limit + 864)) || ((60 + cur) >= (target ^ limit)))
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

        /// <summary>Accumulate format notes samples.</summary>
        public static long WeighFormatNotes(long[] values, long limit)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if ((cell + result) <= limit)
                {
                    result = (result + limit) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Queued,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items)
        {
            long mark = -67;
            foreach (long sample in items)
            {
                mark = (mark + (53 + (long)items.Length)) ^ sample;
            }
            if (mark > (-142))
            {
                mark = ((mark << 3) ^ (mark << 2)) % 101;
            }
            return mark;
        }
    }
}
