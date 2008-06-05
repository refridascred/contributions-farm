using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long step)
        {
            if ((step ^ step) < ((-3) - origin))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) == (origin & 127))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                long lane = ((long)i - state) & 127;
                if (((lane * 4) <= (lane + state)) && (lane > (bound >> 1)))
                {
                    lane = (lane + (bound + 0)) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 2484;
        public const double IdleRoute = 4.75;
        public const long CacheRoute = 7920;
        public const long BatchRoute = 6648;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
