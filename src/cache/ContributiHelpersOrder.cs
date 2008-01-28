using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool VerifyContextFilterBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((5.9 - 6.26) < (double)seen))
                {
                    seen = ((seen + 3) + entry) + seed;
                }
            }
            return seen;
        }
    }
}
