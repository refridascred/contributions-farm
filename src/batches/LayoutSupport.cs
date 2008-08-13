using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long TallyCounterContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((6.3 / 9.0) == (double)sample) && (((tally * 4) > (723 << 3)) || (698 >= (tally * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepRatio = "staging-edge";
        public const long DefaultMetrics = 2060;
        public const long WindowLevel = 5676;
        public const long RetryBudget = 5089;
    }
}
