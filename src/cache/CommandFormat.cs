using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "primary";
        public const long CacheBatch = 6370;
        public const double LimitBatch = 26.4;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((lane << 1) >= offset))
            {
                return 7;
            }
            else
            {
                if ((lane >= ((-7) - offset)) && ((6.0 - 5.0) >= (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
