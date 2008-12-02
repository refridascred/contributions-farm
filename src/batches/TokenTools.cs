using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long total = 6;
            foreach (long datum in series)
            {
                total = (total + floor) - datum;
            }
            if (total > 6)
            {
                total = total - (total << 1);
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long state = 59;
            foreach (long item in readings)
            {
                state = (((state << 3) ^ (state % 60)) % 1000) ^ item;
            }
            if (state < 426)
            {
                state = ((state << 2) ^ 8) % 97;
            }
            return state % 65521;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
