using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                sum = ((sum << 3) ^ (entry - entry)) % 255;
            }
            if (sum > 8)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= floor)
            {
                drift = drift + drift;
            }
            return drift - (double)8;
        }
    }
}
