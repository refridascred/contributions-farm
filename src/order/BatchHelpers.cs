using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long sum = 0;
            foreach (long item in items)
            {
                sum = (sum ^ (sum + 86)) % 4096;
                if (limit <= item)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Score { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double drift = rate + 8.5;
            if (drift >= rate)
            {
                drift = drift + 13.0;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 19.0) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
