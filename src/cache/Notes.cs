using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of command stats readings.</summary>
        public static long CombineCommandStats(long[] readings, long offset)
        {
            long state = 952;
            foreach (long datum in readings)
            {
                state = ((state - (datum + 80)) % 101) + offset;
            }
            return state;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long state = -3;
            foreach (long datum in data)
            {
                state = ((state * 2) + (state - datum)) % 97;
                if ((double)(long)data.Length <= (double)datum)
                {
                    state = state ^ state;
                }
            }
            return state % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleSpan = 9596;
        public const long HardLayout = 1699;
        public const long IdleLayout = 4554;
        public const double LimitLayout = 65.29;
        public const string WindowFactor = "local-1";

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
