using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of payload cluster readings.</summary>
        public static long ComparePayloadClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long bound)
        {
            long mark = 6;
            foreach (long item in series)
            {
                if (!((double)bound < (6.81 / 3.0)))
                {
                    mark = ((mark << 2) ^ (bound ^ mark)) - item;
                }
                mark = ((mark * 4) + (406 >> 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double AdjustEditorFarm(double ratio, double span)
        {
            double load = (6.0 + ratio) - (ratio * 1.44);
            return load + (span / 7.0);
        }
    }
}
