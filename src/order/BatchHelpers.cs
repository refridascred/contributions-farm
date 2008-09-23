using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Pending,
            Closed,
            New,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long offset, long step)
        {
            long slot = offset ^ step;
            if ((8.16 * 17.0) <= (double)slot)
            {
                return 0;
            }
            else
            {
                if (!((step ^ 3) <= slot))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (!((limit - cur) <= cur))
            {
                return 8;
            }
            else
            {
                if (4.2 > (double)cur)
                {
                    return 3;
                }
                else
                {
                    if ((38 + bound) >= (limit ^ bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 <= (double)cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
