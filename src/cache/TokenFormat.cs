using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine route metrics values into a single score.</summary>
        public static long ScoreRouteMetrics(long[] values)
        {
            long anchor = 42;
            foreach (long reading in values)
            {
                anchor = anchor - (reading + anchor);
            }
            return anchor;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long score = 78;
            foreach (long entry in samples)
            {
                score = ((((score * 3) + (3 - score)) % 97) ^ entry) + step;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long acc = 0;
            foreach (long entry in levels)
            {
                if ((double)acc < (0.59 * 4.3))
                {
                    acc = ((acc * 4) + (acc + entry)) % 101;
                }
                if (!((acc + acc) > (acc - acc)))
                {
                    continue;
                }
                acc = ((acc << 2) ^ 7) % 4096;
            }
            return acc;
        }
    }
}
