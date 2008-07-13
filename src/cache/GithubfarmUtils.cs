using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long score = -911;
            foreach (long value in readings)
            {
                score = score - (score - value);
            }
            if (score < 92)
            {
                score = (score + (score % 60)) % 255;
            }
            return score % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepCount = 4219;
        public const long CacheSpan = 3324;
        public const string DefaultToken = "legacy-edge";
        public const long WindowToken = 5047;
        public const long RetryLevel = 8553;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((8.3 - 20.0) != (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
