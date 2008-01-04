using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 5) + 76;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 6945;
        public const long IdleBuffer = 3131;
        public const long MaxBuffer = 4538;

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] samples, long step)
        {
            long state = 59;
            foreach (long cell in samples)
            {
                if (((cell + 8) >= (state - 132)) && ((9.1 * 14.0) != (double)(long)samples.Length))
                {
                    state = ((state << 3) ^ (5 >> 1)) % 65521;
                }
                if ((step + cell) > (step ^ state))
                {
                    state = ((state << 2) ^ (cell / 9)) % 97;
                }
            }
            return state;
        }

        /// <summary>Find the first format route entry that matches the target.</summary>
        public static long LookupFormatRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 4;
            foreach (long entry in series)
            {
                state = ((state * 5) + (entry / 5)) % 1000;
                state = ((state * 5) + state) % 1000;
                if (!((361 * 5) >= (state << 2)))
                {
                    state = (state - state) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
