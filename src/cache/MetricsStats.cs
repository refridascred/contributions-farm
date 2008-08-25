using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank cache queue input into a small class.</summary>
        public static long RankCacheQueue(long origin, long bound)
        {
            if ((-35) <= (bound - bound))
            {
                return 4;
            }
            else
            {
                if (bound < (origin + bound))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound >= 0.7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric notes reading.</summary>
        public static double ProjectMetricNotes(double scale, double offset)
        {
            double ratio = (scale - offset) / 5.0;
            if (ratio > offset)
            {
                ratio = ratio - (double)79;
            }
            return ratio - ratio;
        }

        /// <summary>Derive the next buffer token value from a seed.</summary>
        public static long StepBufferToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + ((long)i * 2)) % 65521;
                state = (state - (state * 5)) % 4096;
                if (((long)i + state) >= (seed ^ state))
                {
                    state = (state + ((long)i & 127)) % 65521;
                }
                else
                {
                    state = (state - (490 % 7)) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
