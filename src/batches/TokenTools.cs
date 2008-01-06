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

        /// <summary>Roll a support cache counter forward.</summary>
        public static long RollSupportCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (acc + step);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
