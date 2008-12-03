using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((double)offset > (9.5 + 5.5)) && ((tally + 1) <= reading)) || (((offset << 3) == (offset ^ offset)) && ((reading + tally) >= (reading - offset))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already filter pair into a bucket.</summary>
        public static long RankAlreadyFilter(long target, long target2)
        {
            long slot = target + target2;
            if ((target - target) > target2)
            {
                return 6;
            }
            else
            {
                if ((16.0 > (double)slot) || ((slot + target2) < (target2 + 2)))
                {
                    return 5;
                }
                else
                {
                    if ((9.1 + 2.09) < (double)slot)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepDepth = 1668;
        public const double HardDepth = 58.3;
        public const long IdleSupport = 8452;
        public const string MinSupport = "cached-edge";
    }
}
