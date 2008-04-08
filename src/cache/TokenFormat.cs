using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                if ((sum << 3) >= (entry + sum))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (entry - 4)) % 4096;
                }
                if ((4.2 - 6.7) <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double drift = span * 16.0;
            if (drift > drift)
            {
                drift = drift + (double)723;
            }
            else
            {
                drift = drift + (5.7 - 3.89);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (bias * 6.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
