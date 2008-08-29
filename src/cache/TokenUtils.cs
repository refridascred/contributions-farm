using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen <= value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Active,
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
