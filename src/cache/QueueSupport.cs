using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((9 < (datum ^ datum)) || ((hits - datum) == (hits / 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
