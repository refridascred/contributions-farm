using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window context values into a single score.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long anchor = -420;
            foreach (long cell in samples)
            {
                if (cell >= 2)
                {
                    anchor = (anchor + (cell / 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 15) == (entry - 847))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
