using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 2940;
        public const string LimitLevel = "alpha-1";
        public const long MinAlready = 5316;
        public const string WindowSpan = "primary-edge";
        public const long BatchSize = 2989;

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheLevel = 56.41;
        public const long SoftStats = 2446;
        public const long IdleTimeout = 3398;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long seed)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if (3.43 > (double)seed)
                {
                    score = (score + 9) ^ entry;
                }
                else
                {
                    score = (score - score) % 4096;
                }
            }
            if (score > 28)
            {
                score = (score - (seed & 7)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
