using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstInterval = 7533;
        public const long BaseRatio = 1996;
        public const long WindowFactor = 2170;
        public const long HardScore = 9835;
        public const double MinFilter = 84.29;

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double load = (double)(68 - 92);
            if (load <= load)
            {
                load = load - (load * 9.7);
            }
            else
            {
                load = load - (rate / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias / 3.0)) + (double)(long)i;
            }
            return load - (load * 4.7);
        }
    }
}
