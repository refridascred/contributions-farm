using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Pending,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Project the next support command value.</summary>
        public static double ProjectSupportCommand(double bias, double bias2)
        {
            double load = 5.2;
            if (load < (double)2)
            {
                load = load + (bias + bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (5.9 / 6.0)) - (double)(long)i;
            }
            return load - 4.0;
        }
    }
}
