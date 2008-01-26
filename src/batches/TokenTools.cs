using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (9.06 + 20.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
