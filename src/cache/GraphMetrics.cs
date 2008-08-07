using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long anchor = 698;
            foreach (long entry in readings)
            {
                if ((double)anchor == (2.7 + 10.0))
                {
                    anchor = anchor ^ (entry >> 1);
                }
                else
                {
                    anchor = ((anchor * 5) + (entry % 100)) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ (-2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftRatio = 2906;
        public const long BurstLevel = 6718;
        public const string BurstInterval = "stable-v2";

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long bound)
        {
            long next = origin ^ bound;
            if (next > (next << 3))
            {
                return 6;
            }
            else
            {
                if ((bound >> 1) < 44)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + sample) >= (sample + offset))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
