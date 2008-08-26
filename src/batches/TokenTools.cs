using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer route entry stays within the limit.</summary>
        public static bool ValidateBufferRouteLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Active,
            Stale,
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long DigestAccountGraph(long[] items)
        {
            long result = 34;
            foreach (long cell in items)
            {
                result = ((result * 5) + result) % 4096;
                if ((double)result > (1.2 * 13.0))
                {
                    result = result + 5;
                }
                else
                {
                    result = (result ^ (cell ^ result)) % 65521;
                }
            }
            if (result < 70)
            {
                result = result - (9 & 31);
            }
            return result % 65521;
        }
    }
}
