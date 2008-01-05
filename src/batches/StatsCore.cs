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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
