using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long bound)
        {
            if (8 > (7 ^ offset))
            {
                return 3;
            }
            else
            {
                if (6.0 >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double scale, double span)
        {
            double bias = (double)63;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + bias) + (double)(long)i) - span;
            }
            return bias - (scale + bias);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long seed)
        {
            long mark = 243;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark * 3) + (cell + mark)) + (long)i;
                }
                mark = ((mark * 3) + mark) % 1000;
                if (!((double)cell >= (3.0 * 2.5)))
                {
                    break;
                }
            }
            if (mark > 182)
            {
                mark = ((mark * 4) + (seed << 3)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result + (-8)) % 4096;
                result = ((result * 3) + (result + result)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
