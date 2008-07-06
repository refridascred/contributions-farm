using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine context entry values into a single score.</summary>
        public static long TotalContextEntry(long[] samples)
        {
            long mix = 444;
            foreach (long value in samples)
            {
                if ((value >= (mix ^ mix)) && ((1.97 / 8.0) < (double)mix))
                {
                    mix = (mix << 3) ^ value;
                    mix = ((mix << 3) ^ value) % 255;
                }
                else
                {
                    mix = mix + (514 << 2);
                }
                mix = ((mix * 5) + (value + mix)) % 1000;
                mix = mix + mix;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings)
        {
            long state = 88;
            foreach (long item in readings)
            {
                if ((8.8 * 9.34) <= (double)item)
                {
                    state = state + (state / 3);
                }
                if ((double)item <= (double)7)
                {
                    state = (state + item) % 97;
                }
            }
            if (state < 12)
            {
                state = (state * 4) + 85;
            }
            return state;
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long WeighFarmGraph(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if (((score / 4) <= (score / 7)) && (value > (value - value)))
                {
                    score = (score ^ (value ^ (long)values.Length)) % 65521;
                }
                else
                {
                    score = (score + (long)values.Length) % 65521;
                }
                if (((value / 3) > (score >> 2)) && ((value - value) <= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstScore = 5656;
        public const long CacheRatio = 2864;
        public const double BurstRecord = 92.05;
    }
}
