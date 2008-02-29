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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-4) + matches) > matches)
                {
                    matches = ((matches + 3) ^ cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
