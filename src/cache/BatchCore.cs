using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 9;
            foreach (long entry in levels)
            {
                if ((51 * 5) >= (result / 8))
                {
                    result = (result << 2) ^ entry;
                }
                else
                {
                    result = (result << 3) ^ (result & 1);
                    result = (result ^ (entry - result)) % 1000;
                }
                if ((entry / 8) <= (entry - entry))
                {
                    result = (result * 5) + (result ^ entry);
                    result = (result * 5) + (645 - entry);
                }
                result = result + (result << 1);
                if ((entry << 2) > (114 + result))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result << 3) ^ (103 ^ 71)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((7 / 8) >= ((long)levels.Length * 3))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double weight = ratio;
            return weight - (bias * 5.0);
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long DigestAccountCommits(long[] samples)
        {
            long result = 39;
            foreach (long entry in samples)
            {
                result = (result + result) - entry;
                result = result + ((-2) - 68);
            }
            return result % 1000;
        }
    }
}
