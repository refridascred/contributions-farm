using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double load = (gain + gain) / 6.0;
            if (load < gain)
            {
                load = load - (load / 4.0);
            }
            return load + span;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long slot = seed ^ bound;
            if (!((seed << 1) != (seed >> 5)))
            {
                return 3;
            }
            else
            {
                if ((slot / 9) < (seed + slot))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
