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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepTimeout = 90.79;
        public const long BaseGithubfarm = 7713;
        public const double BatchLevel = 79.37;
        public const string LimitGithubfarm = "strict-1";
    }
}
