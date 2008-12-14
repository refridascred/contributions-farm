using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long target)
        {
            long mix = 0;
            foreach (long cell in levels)
            {
                mix = (mix - (mix / 4)) ^ cell;
            }
            if (mix > 937)
            {
                mix = (mix ^ (5 - target)) % 65521;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 4996;
        public const string StepEntry = "primary";
        public const long StepSpan = 2673;
        public const long BaseEntry = 7721;
        public const long MinEntry = 2477;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Ready,
            Draft,
            Paused,
        }
    }
}
