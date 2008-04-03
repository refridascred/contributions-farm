using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)79 <= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long floor)
        {
            if ((12.0 + 5.2) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((97 + floor) <= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
