using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchInterval = "fallback-1";
        public const long StepRatio = 7931;
        public const long SoftLayout = 946;
        public const double StepWidth = 89.4;

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] readings)
        {
            long result = 338;
            foreach (long cell in readings)
            {
                if ((result - 36) == (result + result))
                {
                    result = ((result ^ (result + result)) % 255) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Count the profile githubfarm entries that pass the check.</summary>
        public static long TallyProfileGithubfarmHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((double)datum == (18.0 - 1.24)) || (9.7 < (double)count))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
