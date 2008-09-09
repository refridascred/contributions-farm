using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((552 + value) <= value)
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
