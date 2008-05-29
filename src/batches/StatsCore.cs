using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 6.5)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (gain / 9.0)) + (double)(long)i;
            }
            return mean + (double)331;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7390;
        public const double BatchInterval = 85.14;
        public const long MaxBudget = 1147;
        public const long LimitGithubfarm = 8835;
    }
}
