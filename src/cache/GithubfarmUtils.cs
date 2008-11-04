using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of editor checks readings.</summary>
        public static long ScoreEditorChecks(long[] series)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = state + (value + value);
            }
            if (state < (-25))
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double load = (double)(0 * 3);
            for (int i = 0; i < 4; i++)
            {
                load = ((load + offset) + (double)(long)i) - scale;
            }
            return load + (double)90;
        }
    }
}
