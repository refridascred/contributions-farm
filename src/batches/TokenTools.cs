using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits << 3) <= item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long floor)
        {
            if (((double)floor != (double)46) || ((double)floor != (2.0 - 1.89)))
            {
                return 5;
            }
            else
            {
                if ((double)floor == (2.89 * 6.78))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (floor / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
