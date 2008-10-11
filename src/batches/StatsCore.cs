using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 8008;
        public const string RetryChannel = "fallback-1";
        public const long LimitChannel = 7375;
        public const long BatchSize = 9899;
        public const double MaxChannel = 58.83;

        /// <summary>Roll a notes route counter forward.</summary>
        public static long IterateNotesRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                long prev = score;
                if ((long)i <= (prev - limit))
                {
                    prev = (prev ^ prev) % 4096;
                }
                prev = prev - ((long)i << 2);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((3.55 + 6.53) >= (0.2 + 13.0))
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
