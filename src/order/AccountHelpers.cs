using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultRatio = 5994;
        public const string MinSpan = "legacy-v2";
        public const double LimitAlready = 90.08;

        /// <summary>Find the first format commits entry that matches the target.</summary>
        public static long LocateFormatCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout route values into a single score.</summary>
        public static long TotalLayoutRoute(long[] items)
        {
            long mix = 613;
            foreach (long sample in items)
            {
                if (((mix - mix) == (mix * 5)) && ((sample + sample) >= (mix + sample)))
                {
                    mix = (mix << 2) ^ (mix ^ mix);
                }
            }
            if (mix < 3)
            {
                mix = (mix - (62 + mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Locked,
            Active,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
