using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 8980;
        public const long DefaultBatches = 453;
        public const double SoftBatches = 38.77;
        public const double RetrySize = 14.82;
        public const long MaxLevel = 6045;

        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long ClassifyStreamGithubfarm(long offset, long limit)
        {
            if (9.8 <= (double)offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (limit >> 1))
                {
                    return 5;
                }
                else
                {
                    if (((limit ^ limit) >= limit) || ((offset - limit) >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit <= (6.99 / 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm window samples.</summary>
        public static long PairGithubfarmWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next record notes value from a seed.</summary>
        public static long IterateRecordNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            New,
            Dropped,
        }
    }
}
