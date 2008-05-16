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

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long bound)
        {
            long mix = -670;
            foreach (long value in values)
            {
                if ((17.0 + 0.5) < (double)mix)
                {
                    mix = ((((mix << 2) ^ mix) % 97) ^ value) - bound;
                }
            }
            return mix % 4096;
        }

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

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultLevel = 8387;
        public const string BurstBudget = "alpha-edge";
        public const string HardSize = "strict-1";
        public const long WindowDepth = 8265;
    }
}
