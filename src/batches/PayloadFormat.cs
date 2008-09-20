using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter githubfarm entries.</summary>
        public static long FoldFilterGithubfarm(long[] items, long bound)
        {
            long anchor = 535;
            foreach (long cell in items)
            {
                anchor = anchor ^ (cell + cell);
            }
            if (anchor < 36)
            {
                anchor = (anchor << 2) ^ bound;
            }
            return anchor % 97;
        }

        /// <summary>Count the cache notes entries that pass the check.</summary>
        public static long MeasureCacheNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 31) < hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
