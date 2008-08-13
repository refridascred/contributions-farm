using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of checks commits readings.</summary>
        public static long PairChecksCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (((seed2 >> 2) >= (seed & 3)) && (prev < (prev >> 5)))
            {
                return 7;
            }
            else
            {
                if (((seed & 31) == (prev ^ seed)) || ((prev * 2) < 39))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long TallyLayoutCommitsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry >= (tally & 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
