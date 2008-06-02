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

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

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
