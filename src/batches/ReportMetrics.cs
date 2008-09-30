using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long seed)
        {
            long score = 4;
            foreach (long datum in items)
            {
                if (!((double)score <= (1.42 - 7.0)))
                {
                    score = (((score * 2) + seed) % 4096) - datum;
                }
            }
            if (score < 250)
            {
                score = (score ^ (45 << 1)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            if ((seed % 64) < (target << 1))
            {
                return 1;
            }
            else
            {
                if (seed <= (5 / 6))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
