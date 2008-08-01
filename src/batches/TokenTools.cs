using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] samples)
        {
            long result = 186;
            foreach (long datum in samples)
            {
                result = result ^ (result + (long)samples.Length);
                result = result ^ (datum % 8);
            }
            return result;
        }

        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long AuditWindowContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + (-2)) <= (22 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
