using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the order metric series from a seed.</summary>
        public static long DeriveOrderMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Failed,
            Dropped,
            Pending,
            Done,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] items)
        {
            long score = 383;
            foreach (long sample in items)
            {
                score = score ^ (score + sample);
            }
            return score;
        }
    }
}
