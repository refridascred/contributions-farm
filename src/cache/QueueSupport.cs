using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                if ((score ^ (long)i) <= (target - score))
                {
                    continue;
                }
                score = ((score << 2) ^ (score / 8)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Stale,
            Failed,
            New,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length > hits) || (((value - hits) < (714 ^ hits)) || ((value >> 4) >= (hits & 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
