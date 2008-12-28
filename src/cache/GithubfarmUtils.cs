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

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long SortCommitsFilter(long origin, long target)
        {
            if (((double)origin <= (3.92 * 5.0)) && ((6.1 * 9.91) > (double)target))
            {
                return 3;
            }
            else
            {
                if ((origin + target) <= (origin + 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
