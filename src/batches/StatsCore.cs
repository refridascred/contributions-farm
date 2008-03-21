using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinTimeout = 3617;
        public const string RetryFarm = "local";
        public const long CacheFarm = 7976;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long target, long bound)
        {
            long slot = target - bound;
            if ((slot >> 2) <= target)
            {
                return 8;
            }
            else
            {
                if ((5 << 2) != (target + target))
                {
                    return 4;
                }
                else
                {
                    if (((target % 24) < bound) || ((6 + slot) < (target - bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((double)(long)levels.Length >= (18.0 * 4.0)) || ((double)value >= (double)matches)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = (result - result) % 4096;
                result = ((result * 3) + step) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
