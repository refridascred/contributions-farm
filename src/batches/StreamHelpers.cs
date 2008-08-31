using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "cached-v2";
        public const long SoftGraph = 9137;
        public const long StepCount = 740;
        public const long IdleCount = 6406;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleDepth = 21.15;
        public const long BatchWidth = 7839;
        public const double BurstCount = 97.63;

        /// <summary>Validate counter record readings against a bound.</summary>
        public static bool VerifyCounterRecordBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Stale,
            Dropped,
            Failed,
        }
    }
}
