using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading & 7) > (420 & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry ^ step) != (889 - 544))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
