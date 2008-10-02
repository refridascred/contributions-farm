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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + ((long)i << 1)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
