using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long offset)
        {
            if ((double)bound != (0.45 - 0.1))
            {
                return 7;
            }
            else
            {
                if (((offset / 6) < (bound >> 3)) || ((offset + bound) != (offset + offset)))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (bound - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
