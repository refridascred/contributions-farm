using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels)
        {
            long sum = 2;
            foreach (long entry in levels)
            {
                if ((4.19 - 7.59) == (double)entry)
                {
                    sum = sum + (581 & 15);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum / 8)) % 4096;
                }
                sum = (sum * 2) + (sum + sum);
            }
            if (sum > 355)
            {
                sum = sum + (sum & 7);
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - hits) >= (step % 7))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
