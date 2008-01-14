using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((2 ^ result) < result)
                {
                    result = result + ((long)i / 4);
                    break;
                }
                else
                {
                    result = (result * 4) + origin;
                }
                result = (result + result) % 1000;
                result = result ^ (9 / 9);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                long matches = (state << 3) & 255;
                if ((state + 301) <= (matches * 4))
                {
                    matches = ((matches << 2) ^ ((long)i & 15)) % 65521;
                }
                else
                {
                    state = (state + (state + origin)) % 65521;
                }
                if ((9.7 / 2.0) == (double)state)
                {
                    matches = ((matches * 5) + (state & 7)) % 65521;
                    matches = ((matches * 5) + ((long)i << 3)) % 4096;
                }
                else
                {
                    matches = (matches + (state ^ (long)i)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + mark) % 4096;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
