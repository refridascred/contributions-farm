using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long seed)
        {
            long score = 682;
            foreach (long cell in levels)
            {
                score = (score << 3) ^ (seed - score);
                if (cell >= (730 + cell))
                {
                    score = score + score;
                }
                score = score - (cell + cell);
            }
            return score;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Ready,
            Pending,
        }
    }
}
