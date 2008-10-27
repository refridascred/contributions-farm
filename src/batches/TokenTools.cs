using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((bound >> 3) < bound) || ((double)tally > 20.0)) && ((999 & 3) <= (reading ^ 899)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((13.0 * 0.05) > (double)result)
                {
                    result = ((result << 3) ^ floor) % 101;
                    continue;
                }
                result = (result ^ (66 + 47)) % 4096;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Synced,
            Paused,
        }
    }
}
