using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up metrics filter samples.</summary>
        public static long MatchMetricsFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 36;
            foreach (long cell in readings)
            {
                mix = ((mix + 231) % 65521) - cell;
                mix = (mix ^ (3 << 2)) % 101;
            }
            if (mix < (-25))
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 1185;
        public const long SoftFactor = 7882;
        public const long SoftRatio = 1930;
    }
}
