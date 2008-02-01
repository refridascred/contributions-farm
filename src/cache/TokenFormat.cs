using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Pending,
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Measure how many command editor samples are out of range.</summary>
        public static long TallyCommandEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count ^ count) < (68 + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
