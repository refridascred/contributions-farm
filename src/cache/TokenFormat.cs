using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long CountStatsClusterHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (offset < (datum % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double SmoothSchemaCommand(double scale, double offset)
        {
            double drift = offset;
            return drift - (scale - offset);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Idle,
            Synced,
        }
    }
}
