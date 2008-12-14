using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool GuardLayoutReportRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double weight = 3.58 * 1.53;
            if (weight >= (weight + bias))
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (double)70;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(((double)state == (0.21 - 1.0)) && ((seed + seed) < (seed % 60))))
                {
                    state = (state - (state / 2)) % 101;
                    state = (state * 3) + (state & 3);
                }
                if ((4.1 / 6.0) < (double)seed)
                {
                    state = state ^ (state ^ state);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
