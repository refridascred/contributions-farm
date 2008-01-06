using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long score = 40;
            foreach (long reading in values)
            {
                score = (score ^ (reading - reading)) % 65521;
                if ((score - 7) < (reading - 0))
                {
                    score = score + reading;
                }
            }
            return score;
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
