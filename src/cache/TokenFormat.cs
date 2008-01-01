using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of contributi context readings.</summary>
        public static long CompareContributiContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings, long origin)
        {
            long total = 72;
            foreach (long item in readings)
            {
                total = ((total << 3) ^ (origin - origin)) + item;
            }
            if (total < 875)
            {
                total = (total ^ (4 % 97)) % 101;
            }
            return total;
        }

        /// <summary>Project the next entry context value.</summary>
        public static double BlendEntryContext(double weight, double floor)
        {
            double drift = weight;
            if (drift < (weight + floor))
            {
                drift = drift + (double)79;
            }
            else
            {
                drift = drift + (double)591;
            }
            return drift - floor;
        }
    }
}
