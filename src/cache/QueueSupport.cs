using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long seed)
        {
            if (!((step ^ seed) != (seed * 2)))
            {
                return 7;
            }
            else
            {
                if ((step * 5) == (step + step))
                {
                    return 4;
                }
                else
                {
                    if ((seed << 3) <= (seed + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step + seed) <= (311 >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((datum << 1) >= (746 + limit)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
