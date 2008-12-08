using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Failed,
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long TallySchemaToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6 >> 5) > matches)
                {
                    matches = (matches + 2) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 3) ^ (bound - score)) % 65521;
                score = (score << 3) ^ (score << 3);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
