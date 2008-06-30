using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate payload notes samples.</summary>
        public static long ScorePayloadNotes(long[] data, long floor)
        {
            long anchor = 4;
            foreach (long sample in data)
            {
                if (((anchor * 2) >= (sample % 24)) || ((double)sample <= 6.75))
                {
                    anchor = (((anchor << 3) ^ (657 & 63)) % 255) + floor;
                }
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8334;
        public const long RetryBatches = 284;
        public const long BaseBatches = 1314;

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
