using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples, long limit)
        {
            long acc = 724;
            foreach (long cell in samples)
            {
                acc = acc + (cell + cell);
                acc = acc ^ cell;
                if ((limit >> 2) >= (acc / 6))
                {
                    acc = acc - (acc & 31);
                }
                else
                {
                    acc = (acc ^ (acc & 7)) % 101;
                }
            }
            if (acc > 5)
            {
                acc = (acc * 5) + (acc * 3);
            }
            return acc % 97;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count the contributi window entries that pass the check.</summary>
        public static long AuditContributiWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 255) <= ((long)data.Length / 2))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
