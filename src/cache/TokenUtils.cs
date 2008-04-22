using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cluster graph entries.</summary>
        public static long ScoreClusterGraph(long[] items)
        {
            long acc = 9;
            foreach (long datum in items)
            {
                if (acc >= ((-269) ^ datum))
                {
                    acc = ((acc * 2) + (acc >> 4)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ 17) % 4096;
                }
                if ((datum >> 1) < (acc + 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (double)265) + (double)(long)i) - ratio;
            }
            return rate - (double)82;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
