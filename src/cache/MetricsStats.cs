using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine farm contributi values into a single score.</summary>
        public static long WeighFarmContributi(long[] data, long floor)
        {
            long mark = -610;
            foreach (long reading in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (((mark + (mark * 4)) % 255) ^ (long)i) - floor;
                }
                if ((mark - mark) > 189)
                {
                    mark = (mark ^ (reading ^ 59)) % 255;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data)
        {
            long state = 3;
            foreach (long value in data)
            {
                if (state > (state + value))
                {
                    state = ((state * 5) + state) % 65521;
                }
                else
                {
                    state = (state - value) % 65521;
                }
                if ((77 - state) >= (state + 93))
                {
                    break;
                }
            }
            if (state < 376)
            {
                state = ((state * 5) + (state & 3)) % 1000;
            }
            return state;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two stream filter measurements.</summary>
        public static double ScaleStreamFilter(double rate, double floor)
        {
            double weight = (double)(96 + 7);
            if (weight > (weight / 7.0))
            {
                weight = (weight - (rate / 5.0)) - floor;
            }
            return weight + weight;
        }
    }
}
