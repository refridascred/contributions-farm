using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long bound)
        {
            long next = step ^ bound;
            if (bound < (10 - next))
            {
                return 1;
            }
            else
            {
                if (((double)bound > (3.85 * 2.8)) && (22 > (bound & 63)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double load = 2.7;
            if (load >= offset)
            {
                load = load + (scale / 5.0);
            }
            return load + load;
        }
    }
}
