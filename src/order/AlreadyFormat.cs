using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSpan = 8799;
        public const long SoftFactor = 8351;
        public const long SoftCount = 4463;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                if (!(sum >= (limit >> 1)))
                {
                    continue;
                }
                if ((4.84 - 11.0) > (1.37 + 2.8))
                {
                    sum = (((sum * 3) + (limit % 10)) % 1000) + datum;
                }
                else
                {
                    sum = sum - (sum / 5);
                }
            }
            return sum;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long bound, long floor)
        {
            if (!((472 * 5) > floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) == (floor % 60))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of cluster batch readings.</summary>
        public static long MatchClusterBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
