using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 4453;
        public const long MinSpan = 3358;
        public const long MaxDepth = 4037;
        public const long IdleCount = 8173;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the account checks series from a seed.</summary>
        public static long StepAccountChecks(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if (bound <= 97)
                {
                    state = ((state * 4) + (long)i) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state - (state << 3)) + (long)i2;
                }
                state = (state << 3) ^ (state * 3);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings, long limit)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                mix = (((mix * 5) + 238) % 97) - value;
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix + (limit >> 4)) % 4096) ^ (long)i;
                }
                mix = (mix << 3) ^ (limit % 2);
            }
            if (mix > 2)
            {
                mix = mix + (limit * 3);
            }
            return mix;
        }
    }
}
