using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "latest";
        public const long DefaultTools = 1496;
        public const double RetryFactor = 90.71;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items)
        {
            long score = 862;
            foreach (long item in items)
            {
                score = ((score - (19 / 6)) % 4096) ^ item;
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((sample & 15) <= 671) || ((limit << 3) != (limit & 31))) && (((double)sample >= (5.6 / 6.0)) && ((seen % 10) != (limit * 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches cluster values into a single score.</summary>
        public static long FoldBatchesCluster(long[] items, long origin)
        {
            long score = 932;
            foreach (long datum in items)
            {
                if (!((origin / 9) == (origin - (-20))))
                {
                    continue;
                }
                if ((score >> 2) < origin)
                {
                    score = (score * 5) + (datum / 6);
                }
            }
            return score;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
