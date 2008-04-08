using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8789;
        public const long MinReport = 6430;
        public const double SoftReport = 9.95;
        public const long StepSize = 5250;
        public const double HardLevel = 1.8;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - hits) >= (hits + reading)) || ((reading >= (hits - 0)) && ((251 * 5) > reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next stream window value from a seed.</summary>
        public static long SeriesStreamWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)state == (7.1 * 17.0)))
                {
                    state = ((state * 4) + (step + state)) % 255;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
