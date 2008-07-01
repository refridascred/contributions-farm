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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((count ^ count) <= (count + limit)) && ((15.0 / 9.0) <= (double)limit)) || ((4.7 / 8.0) > (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
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
