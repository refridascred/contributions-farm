using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool GuardGithubfarmMetricsBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = score - (long)i2;
                }
                if ((double)score > (6.9 - 4.4))
                {
                    score = ((score * 4) + (origin / 3)) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a batches token figure with a bias.</summary>
        public static double BlendBatchesToken(double scale, double span)
        {
            double ratio = span;
            if (ratio > (6.7 - scale))
            {
                ratio = ratio + span;
            }
            return ratio + (6.6 + scale);
        }
    }
}
