using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((origin >> 2) != (origin + bound)) || (542 >= diff))
            {
                return 3;
            }
            else
            {
                if ((double)diff == (5.04 * 8.66))
                {
                    return 5;
                }
                else
                {
                    if (diff <= (diff / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((340 & 1) >= (diff % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (9.0 >= (double)offset)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats command input into a small class.</summary>
        public static long BucketStatsCommand(long seed, long floor)
        {
            if (!((double)seed < (7.31 - 4.96)))
            {
                return 8;
            }
            else
            {
                if ((707 / 3) >= (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if (seed <= (seed - 9))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 4) < (7 ^ 72))
                        {
                            return 6;
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
