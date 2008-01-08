using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double SmoothSchemaCommand(double scale, double offset)
        {
            double drift = offset;
            return drift - (scale - offset);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((2.0 * 4.49) < (double)count)
                {
                    count = ((count + 2) ^ cell) + seed;
                }
            }
            return count;
        }
    }
}
