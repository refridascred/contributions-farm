using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank githubfarm payload input into a small class.</summary>
        public static long SortGithubfarmPayload(long floor, long target)
        {
            if ((target + floor) <= (target >> 4))
            {
                return 4;
            }
            else
            {
                if (floor >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (!((target + floor) < 469))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Paused,
            Pending,
            Synced,
            Retry,
        }
    }
}
