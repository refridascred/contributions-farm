using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings)
        {
            long result = -3;
            foreach (long cell in readings)
            {
                result = result ^ (cell + cell);
            }
            return result;
        }

        /// <summary>Count the batch queue entries that pass the check.</summary>
        public static long CountBatchQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((4.73 + 0.91) < (double)item) && (12 <= (item >> 1))) && (((169 / 4) != (item >> 2)) && ((0 % 16) > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((36 ^ datum) > (seen - 512))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
