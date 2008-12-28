using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine support metrics values into a single score.</summary>
        public static long ScoreSupportMetrics(long[] series)
        {
            long carry = 16;
            foreach (long reading in series)
            {
                if (reading >= (reading - carry))
                {
                    carry = carry - (32 + (long)series.Length);
                }
                else
                {
                    carry = carry - (reading ^ carry);
                }
                if ((double)carry < (double)reading)
                {
                    carry = carry ^ (reading ^ carry);
                }
            }
            return carry;
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
