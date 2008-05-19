using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 338;
        public const string WindowSize = "cached";
        public const long IdleGithubfarm = 2053;
        public const string StepGithubfarm = "staging-edge";

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long state = 618;
            foreach (long item in items)
            {
                if ((state - item) > (742 % 60))
                {
                    state = ((state << 3) ^ item) % 1000;
                }
                else
                {
                    state = (state * 5) + state;
                }
                if ((double)state < 18.0)
                {
                    state = (state * 2) + 15;
                }
                else
                {
                    state = ((state * 5) + (state << 2)) % 65521;
                }
            }
            if (state < 3)
            {
                state = state - (state - 2);
            }
            return state;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Pending,
            New,
            Paused,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Idle,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((offset ^ cell) <= (cell * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
