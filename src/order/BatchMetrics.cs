using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples)
        {
            long total = 0;
            foreach (long sample in samples)
            {
                total = ((total << 3) ^ total) % 65521;
                if ((sample << 1) < (total * 5))
                {
                    total = total ^ (sample >> 1);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 7618;
        public const string CacheChecks = "local";
        public const long BurstChecks = 7359;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long score = -7;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (reading + (long)levels.Length)) % 255;
            }
            return score % 65521;
        }
    }
}
