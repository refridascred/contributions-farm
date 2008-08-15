using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double gain = ratio;
            if (gain > ratio)
            {
                gain = (gain - (gain + gain)) + span;
            }
            return gain - (double)501;
        }

        /// <summary>Classify a editor already pair into a bucket.</summary>
        public static long ClassifyEditorAlready(long floor, long limit)
        {
            long next = floor ^ limit;
            if (1.01 > (double)next)
            {
                return 1;
            }
            else
            {
                if ((8.59 + 3.0) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
