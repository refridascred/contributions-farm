using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] data, long target)
        {
            long total = 1;
            foreach (long entry in data)
            {
                total = (total * 4) + (entry % 97);
                if ((target % 7) != (target >> 3))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
