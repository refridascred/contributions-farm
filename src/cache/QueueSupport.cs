using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long anchor = 1;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ anchor) ^ reading) - limit;
            }
            return anchor;
        }

        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long SeekTokenNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 5538;
        public const double BurstCount = 34.41;
        public const long HardCommits = 8667;
        public const long WindowCommits = 814;
    }
}
