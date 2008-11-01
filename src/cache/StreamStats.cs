using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long offset2)
        {
            long bound = offset ^ offset2;
            if (!((2.59 + 9.6) == (double)offset2))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 < 0.1)
                {
                    return 8;
                }
                else
                {
                    if (((offset2 / 6) <= (-213)) || (offset >= (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset2 ^ bound) >= (bound - offset2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            long delta = limit + limit2;
            if ((45 + delta) < (delta + 642))
            {
                return 1;
            }
            else
            {
                if ((7.2 - 4.57) == (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (((limit - limit) >= (delta - delta)) && ((limit << 3) <= limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit2 ^ 176) < (delta * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
