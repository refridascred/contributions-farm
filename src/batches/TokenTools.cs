using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long bound)
        {
            long edge = step - bound;
            if (!((step & 15) == (edge - bound)))
            {
                return 7;
            }
            else
            {
                if ((50 ^ step) < (bound + step))
                {
                    return 3;
                }
                else
                {
                    if (step < edge)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
