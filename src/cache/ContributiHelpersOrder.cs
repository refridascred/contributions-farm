using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Count already support pairs that satisfy a relation.</summary>
        public static long MatchAlreadySupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
