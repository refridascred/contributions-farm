using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] values, long step)
        {
            long total = 6;
            foreach (long value in values)
            {
                total = ((total * 3) + (value % 5)) % 255;
            }
            if (total > 404)
            {
                total = (total ^ (step / 5)) % 97;
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
