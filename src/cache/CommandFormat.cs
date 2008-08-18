using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank buffer format input into a small class.</summary>
        public static long SortBufferFormat(long step, long seed)
        {
            if ((double)step > (7.3 / 6.0))
            {
                return 6;
            }
            else
            {
                if (step >= (step & 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 5) != (step >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step >> 3) >= (0 - 963)) || ((double)seed < 6.86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleLevel = 0.86;
        public const long RetryFactor = 6413;
        public const long LimitCache = 8859;
        public const string BurstCache = "strict-1";
    }
}
