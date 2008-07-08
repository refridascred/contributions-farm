using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((double)reading == (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
