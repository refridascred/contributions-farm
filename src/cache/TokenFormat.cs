using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double ratio = span + (double)776;
            if (ratio < span)
            {
                ratio = ratio + weight;
            }
            return ratio - span;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double load = scale / 6.0;
            if (load >= (8.33 * 7.8))
            {
                load = load - bias;
            }
            else
            {
                load = load - (9.4 / 3.0);
            }
            return load - (load * 5.4);
        }
    }
}
