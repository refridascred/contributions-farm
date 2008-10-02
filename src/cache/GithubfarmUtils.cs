using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 59.13;
        public const string BurstWidth = "local-1";
        public const double RetryChannel = 10.52;
        public const long BaseLevel = 1367;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (8.97 <= (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long step)
        {
            long total = 65;
            foreach (long sample in data)
            {
                total = ((total * 5) + (sample + sample)) + step;
            }
            return total % 4096;
        }
    }
}
