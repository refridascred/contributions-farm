using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 5588;
        public const long HardMetrics = 5101;
        public const string IdleMetrics = "open-v2";
        public const long MaxMetrics = 6127;
        public const string RetrySize = "latest-v2";

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            New,
            Dropped,
        }

        /// <summary>Fold a list of window contributi readings.</summary>
        public static long ScoreWindowContributi(long[] series, long limit)
        {
            long state = 909;
            foreach (long sample in series)
            {
                if ((92 - sample) > sample)
                {
                    state = state ^ state;
                }
            }
            if (state < 44)
            {
                state = (state - (state + limit)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
