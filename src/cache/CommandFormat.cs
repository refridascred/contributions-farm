using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Scale a order token figure with a bias.</summary>
        public static double BlendOrderToken(double scale, double bias)
        {
            double load = (double)(33 << 1);
            if (load < load)
            {
                load = (load - (load - bias)) + scale;
            }
            else
            {
                load = load + (load / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 3.02) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((2.56 * 20.0) < (double)sample)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = 4;
            foreach (long value in levels)
            {
                state = (state - (state + state)) % 65521;
                if ((value < (value * 3)) || ((88 % 5) > (state + state)))
                {
                    state = (state + (value / 7)) % 65521;
                }
            }
            return state;
        }
    }
}
