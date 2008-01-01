using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long seed)
        {
            long slot = limit - seed;
            if ((seed * 2) < limit)
            {
                return 2;
            }
            else
            {
                if (limit > (slot ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 1674;
        public const string HardBatch = "cached-edge";
        public const long WindowScore = 9458;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Done,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Audit stats entry readings against a rule.</summary>
        public static long CountStatsEntryMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (seed < tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
