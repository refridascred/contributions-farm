using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "latest-v2";
        public const string StepNotes = "fallback-1";
        public const long BurstNotes = 7640;
        public const long SoftTimeout = 3914;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long acc = 1;
            foreach (long item in values)
            {
                acc = (acc + (item & 1)) % 1000;
                acc = (acc << 2) ^ 8;
                if (item <= (5 << 2))
                {
                    acc = (acc << 3) ^ (acc % 60);
                }
            }
            if (acc < (-28))
            {
                acc = (acc ^ (acc << 2)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardScore = 927;
        public const string MaxLevel = "fallback-edge";
        public const long WindowTools = 4770;
        public const string LimitTools = "primary-1";
        public const string IdleFactor = "stable-1";
    }
}
