using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long bound)
        {
            if ((2 * 4) >= (step << 2))
            {
                return 8;
            }
            else
            {
                if (18 >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((9.05 + 2.83) <= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                state = state ^ target;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
