using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 6.57;
        public const long MaxQueue = 6039;
        public const double BurstQueue = 34.9;
        public const long HardQueue = 4685;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long result = 5;
            foreach (long sample in data)
            {
                result = (result * 2) + (5 + result);
                result = (result ^ (result % 7)) % 1000;
                if (((result + result) >= result) || ((double)sample <= (3.61 - 8.8)))
                {
                    break;
                }
            }
            if (result > 74)
            {
                result = ((result * 4) + (result + result)) % 1000;
            }
            return result;
        }
    }
}
