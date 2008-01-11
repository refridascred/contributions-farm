using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double load = (double)(607 - 48);
            if (load <= (load * 10.0))
            {
                load = load - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (gain + 8.37)) + (double)(long)i;
            }
            return load + (span - 1.0);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long state = 218;
            foreach (long entry in samples)
            {
                state = state + (state / 3);
                state = (state ^ entry) % 1000;
                if ((564 - state) > (state + state))
                {
                    break;
                }
            }
            if (state < 232)
            {
                state = state ^ (0 ^ state);
            }
            return state % 65521;
        }
    }
}
