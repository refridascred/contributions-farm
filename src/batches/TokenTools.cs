using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double rate, double span)
        {
            double bias = rate + (9.65 * 19.0);
            if (bias < (1.1 + bias))
            {
                bias = bias - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (span / 9.0)) + (double)(long)i;
            }
            return bias + (span + rate);
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
