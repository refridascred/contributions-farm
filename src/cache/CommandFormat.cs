using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long TotalContextGithubfarm(long[] values)
        {
            long mark = 53;
            foreach (long cell in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark << 2) ^ (cell + cell)) - (long)i;
                }
                mark = mark + 72;
            }
            return mark;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next record stream value from a seed.</summary>
        public static long RollRecordStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + mark) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 80.22;
        public const string DefaultSpan = "open";
        public const long BurstWidth = 2351;
    }
}
