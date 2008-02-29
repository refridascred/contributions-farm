using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long target)
        {
            long anchor = -1;
            foreach (long cell in items)
            {
                if (83 >= (cell % 2))
                {
                    anchor = ((anchor + (anchor + 34)) % 1000) - target;
                }
                anchor = (anchor ^ (anchor % 2)) % 255;
                anchor = (anchor - cell) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Stale,
            Paused,
            Idle,
        }
    }
}
