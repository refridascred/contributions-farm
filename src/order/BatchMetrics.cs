using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long origin)
        {
            if ((951 >= (origin + origin)) || ((133 * 5) <= origin))
            {
                return 0;
            }
            else
            {
                if ((-503) <= limit)
                {
                    return 3;
                }
                else
                {
                    if ((origin % 8) >= (640 ^ 0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = gain;
            if (load > load)
            {
                load = load - load;
            }
            return load + floor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long state = 704;
            foreach (long cell in series)
            {
                state = (state ^ (state + state)) - cell;
            }
            if (state > 60)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits graph value.</summary>
        public static double ProjectCommitsGraph(double ratio, double bias)
        {
            double rate = (double)(737 ^ 105);
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (bias + bias)) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
