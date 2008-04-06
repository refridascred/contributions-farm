using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up session window samples.</summary>
        public static long MatchSessionWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Synced,
            Idle,
            Stale,
            Draft,
        }
    }
}
