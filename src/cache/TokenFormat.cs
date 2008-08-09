using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a order account figure with a bias.</summary>
        public static double BlendOrderAccount(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight / 9.0)) - (double)(long)i;
            }
            return load + (load - weight);
        }

        /// <summary>Look up the position of a checks session sample.</summary>
        public static long LookupChecksSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long origin, long step)
        {
            if (origin < (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) < (origin + step))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
