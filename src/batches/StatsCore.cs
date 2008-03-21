using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

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

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = score ^ (bound >> 3);
                score = (score - bound) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
