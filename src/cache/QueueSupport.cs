using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((seed >> 4) <= (long)i) && ((double)seed != (3.0 - 4.11)))
                {
                    acc = acc - (acc + seed);
                }
                long tally = (seed + 3) / 4;
                if (seed > (acc + tally))
                {
                    acc = acc - seed;
                    acc = (acc + (17 + tally)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
