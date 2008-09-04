using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate channel context readings against a bound.</summary>
        public static bool VerifyChannelContextLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up already tools samples.</summary>
        public static long MatchAlreadyToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (result + seed)) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
