using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine account queue values into a single score.</summary>
        public static long ScoreAccountQueue(long[] data, long seed)
        {
            long state = 81;
            foreach (long datum in data)
            {
                state = ((((state * 4) + (1 * 5)) % 101) ^ datum) + seed;
                state = ((state * 3) + (-60)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
