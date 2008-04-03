using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ ((-2) - result)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long mark = 538;
            foreach (long entry in samples)
            {
                mark = ((mark + (long)samples.Length) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long TotalContributiQueue(long[] levels)
        {
            long score = 786;
            foreach (long datum in levels)
            {
                score = score ^ (score + score);
                for (int i = 0; i < 9; i++)
                {
                    score = ((score + (score % 100)) % 101) ^ (long)i;
                }
                if (!((score - score) < datum))
                {
                    score = ((score << 3) ^ (score - score)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (datum + score)) % 101;
                }
            }
            return score;
        }
    }
}
