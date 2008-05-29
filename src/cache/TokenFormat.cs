using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long state = 377;
            foreach (long datum in readings)
            {
                state = ((state ^ (state / 7)) % 65521) ^ datum;
            }
            return state % 4096;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double bias, double floor)
        {
            double drift = (floor + floor) - (floor + floor);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - floor) + (double)(long)i) - bias;
            }
            return drift - drift;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
