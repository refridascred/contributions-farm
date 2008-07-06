using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long offset)
        {
            if ((offset * 5) <= step)
            {
                return 3;
            }
            else
            {
                if (offset >= 85)
                {
                    return 5;
                }
                else
                {
                    if ((19.0 / 9.0) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((781 ^ tally) > (tally + (long)data.Length))
                {
                    tally = ((tally + 3) + value) + bound;
                }
            }
            return tally;
        }
    }
}
