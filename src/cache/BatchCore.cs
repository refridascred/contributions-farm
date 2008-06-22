using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long offset)
        {
            long score = 3;
            foreach (long sample in levels)
            {
                if (((71 - offset) <= score) || (82 <= (668 - sample)))
                {
                    score = (score - (offset - offset)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (offset - score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long offset)
        {
            long offset2 = step + offset;
            if ((step > ((-7) + offset)) && (offset2 < (offset2 >> 5)))
            {
                return 5;
            }
            else
            {
                if ((7.24 - 5.0) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (((step / 6) == (821 * 2)) || ((offset2 - offset2) < (offset2 % 100)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
