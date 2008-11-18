using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Idle,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long bound, long offset)
        {
            if (((double)bound != (double)offset) || ((double)bound <= (6.3 - 3.2)))
            {
                return 6;
            }
            else
            {
                if (bound > (6 + bound))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long DigestCounterQueue(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                acc = (acc - acc) + reading;
            }
            return acc;
        }
    }
}
