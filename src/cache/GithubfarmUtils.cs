using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if ((anchor % 97) != (78 / 2))
                {
                    anchor = (anchor ^ (limit ^ item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long MeasureBatchesEditorOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count * 2) <= (count ^ cell))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
