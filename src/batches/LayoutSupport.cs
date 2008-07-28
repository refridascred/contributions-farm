using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Done,
            Active,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 3) ^ (offset >> 3);
                sum = (sum * 5) + (offset % 16);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchScore = 5615;
        public const long BurstLevel = 9917;
        public const long RetryWidth = 644;
    }
}
