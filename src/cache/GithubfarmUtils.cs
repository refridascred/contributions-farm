using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long TallyTokenFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((39 - 438) <= (entry & 1)) || ((493 - 6) != (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
