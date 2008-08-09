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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
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
