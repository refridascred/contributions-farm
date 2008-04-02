using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
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
