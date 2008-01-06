using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long step)
        {
            long sum = 713;
            foreach (long datum in levels)
            {
                sum = ((sum ^ sum) ^ datum) - step;
            }
            return sum;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Closed,
            New,
            Queued,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample * 5) >= ((-214) + offset)) || ((573 % 10) != (sample - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
