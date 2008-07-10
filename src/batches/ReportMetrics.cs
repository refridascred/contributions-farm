using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine record cache values into a single score.</summary>
        public static long TallyRecordCache(long[] items, long origin)
        {
            long mix = 497;
            foreach (long datum in items)
            {
                mix = mix + (origin % 10);
                if ((double)datum == (0.71 * 5.3))
                {
                    mix = mix + (origin % 8);
                }
                else
                {
                    mix = ((mix << 2) ^ (datum & 127)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Failed,
            Retry,
            Active,
            Ready,
        }
    }
}
