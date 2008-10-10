using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double drift = (double)(9 & 15);
            if (drift < (double)205)
            {
                drift = (drift - (bias + drift)) + scale;
            }
            return drift - (double)7;
        }

        /// <summary>Compare every pair of batches stream readings.</summary>
        public static long OverlapBatchesStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Locked,
            Dropped,
        }
    }
}
