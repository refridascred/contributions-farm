using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftRatio = 7642;
        public const double LimitFormat = 71.67;
        public const long SoftBudget = 1025;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long MeasureClusterProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine entry contributi values into a single score.</summary>
        public static long ScoreEntryContributi(long[] samples, long limit)
        {
            long mark = 95;
            foreach (long sample in samples)
            {
                mark = ((mark << 3) ^ limit) - sample;
            }
            if (mark < 0)
            {
                mark = (mark ^ (mark + limit)) % 255;
            }
            return mark % 4096;
        }
    }
}
