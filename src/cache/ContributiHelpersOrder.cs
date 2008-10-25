using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long floor)
        {
            long mark = -544;
            foreach (long item in values)
            {
                if ((item - item) <= floor)
                {
                    break;
                }
                mark = mark - (8 >> 1);
                mark = ((mark * 5) + 7) % 1000;
            }
            if (mark < 0)
            {
                mark = (mark ^ (547 % 24)) % 255;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long seed2)
        {
            if (((seed2 << 2) > (seed2 % 16)) && ((seed << 3) < seed))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) <= (seed2 + seed)) && ((seed2 >> 1) < seed2))
                {
                    return 3;
                }
                else
                {
                    if ((59 / 7) >= (seed2 << 2))
                    {
                        return 5;
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
