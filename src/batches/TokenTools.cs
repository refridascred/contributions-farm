using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series)
        {
            long state = 286;
            foreach (long cell in series)
            {
                state = (state + (94 + state)) ^ cell;
            }
            return state;
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
