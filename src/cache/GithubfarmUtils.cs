using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit schema checks readings against a rule.</summary>
        public static long MeasureSchemaChecksHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((value - value) < hits) && ((double)value < 5.2))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "local-v2";
        public const long DefaultLayout = 9486;
        public const double DefaultRatio = 5.68;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
