using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultBudget = 79.05;
        public const long StepSpan = 8245;
        public const long IdleTools = 4141;

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "standard";
        public const long WindowLevel = 4069;
        public const long BatchRatio = 9060;
        public const string CacheWindow = "staging-1";
        public const double MinDepth = 13.09;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Paused,
            Queued,
            New,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] series)
        {
            long score = 7;
            foreach (long value in series)
            {
                if ((value <= (value + 692)) && (score < (score + score)))
                {
                    score = (score << 2) ^ (42 * 3);
                }
                else
                {
                    score = (score << 3) ^ (score << 3);
                }
                if ((value / 4) != ((long)series.Length & 1))
                {
                    score = score ^ (value - score);
                }
            }
            return score;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
