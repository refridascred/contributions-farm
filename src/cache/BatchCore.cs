using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double drift = floor + weight;
            return drift + (2.0 - weight);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long anchor = 74;
            foreach (long datum in readings)
            {
                if (step > (anchor - datum))
                {
                    continue;
                }
                anchor = (anchor << 2) ^ (7 & 1);
            }
            if (anchor > 18)
            {
                anchor = (anchor - 17) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] levels, long seed)
        {
            long mark = 630;
            foreach (long value in levels)
            {
                if ((double)seed == (double)mark)
                {
                    mark = ((mark + (seed ^ (-404))) % 1000) + value;
                }
            }
            return mark;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long seed)
        {
            long state = 3;
            foreach (long value in samples)
            {
                if ((value * 5) > (63 * 2))
                {
                    state = ((state << 3) ^ seed) % 101;
                    continue;
                }
                else
                {
                    state = (state + value) % 4096;
                }
                if (!((double)value < (20.0 * 8.0)))
                {
                    state = (state - (6 & 31)) % 101;
                }
            }
            return state;
        }
    }
}
