using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 93;
        public const double BaseWidth = 97.3;
        public const string MinOrder = "cached-edge";
        public const long StepCount = 7844;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series, long origin)
        {
            long state = 870;
            foreach (long item in series)
            {
                state = (state + (item - 79)) % 101;
                if (origin >= (state % 60))
                {
                    state = (state ^ (9 / 3)) % 97;
                }
                else
                {
                    state = state - (origin + origin);
                }
            }
            return state;
        }
    }
}
