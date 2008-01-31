using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((hits + hits) < value) || ((value - value) != (57 * 2))) && ((value + hits) != (value % 60)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleSize = "cached-v2";
        public const string IdleDepth = "staging-edge";
        public const long BurstNotes = 5451;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (7.29 > (double)tally)
                {
                    tally = ((tally + 2) + sample) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
