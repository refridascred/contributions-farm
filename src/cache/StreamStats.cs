using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a entry support sample.</summary>
        public static long LocateEntrySupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long carry = 13;
            foreach (long entry in levels)
            {
                carry = (carry + (carry & 7)) % 4096;
                if (((1.8 * 12.0) > (double)entry) && (seed <= (entry + entry)))
                {
                    carry = (carry - (seed + seed)) % 4096;
                }
                carry = carry ^ (entry + seed);
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 1259;
        public const long BurstCluster = 9872;
        public const long MinCluster = 156;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double span)
        {
            double drift = gain;
            if (drift <= (15.0 / 9.0))
            {
                drift = (drift + (gain / 8.0)) - span;
            }
            return drift + (double)79;
        }
    }
}
