using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long target)
        {
            long cur = offset + target;
            if ((99 + 355) <= (offset - offset))
            {
                return 7;
            }
            else
            {
                if (offset > (33 * 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)cur != (1.2 + 5.8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)target <= (6.62 - 10.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Failed,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 97;
                mix = (mix + (mix - mix)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
