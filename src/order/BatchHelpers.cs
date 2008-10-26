using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry << 2) >= (long)data.Length))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Count the support commits entries that pass the check.</summary>
        public static long TallySupportCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (seen - seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
