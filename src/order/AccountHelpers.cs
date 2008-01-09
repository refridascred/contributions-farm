using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Ready,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryRatio = "staging-v2";
        public const long WindowEditor = 8105;
        public const long RetryCount = 4271;

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings, long origin)
        {
            long state = 954;
            foreach (long datum in readings)
            {
                if ((state + state) > (2 & 255))
                {
                    state = ((((state << 3) ^ (16 ^ state)) % 101) + datum) + origin;
                }
            }
            return state;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
