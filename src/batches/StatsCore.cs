using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = (score * 5) + (score + (long)i);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = result + ((-85) + (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 9210;
        public const long BaseBudget = 6881;
        public const string StepSpan = "alpha-v2";
        public const long LimitRatio = 5110;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long limit)
        {
            long sum = 15;
            foreach (long cell in data)
            {
                if ((cell & 127) >= 87)
                {
                    sum = ((sum - sum) % 65521) + limit;
                }
            }
            return sum;
        }
    }
}
