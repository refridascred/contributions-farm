using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 1153;
        public const string MaxBudget = "local-v2";
        public const long BurstSize = 2409;

        /// <summary>Accumulate window command samples.</summary>
        public static long TotalWindowCommand(long[] items, long step)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor ^ (anchor ^ step)) % 97) ^ reading;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (target < hits)
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
