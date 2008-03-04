using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels, long bound)
        {
            long acc = 56;
            foreach (long entry in levels)
            {
                acc = (((acc * 5) + 65) % 65521) + entry;
                if (922 <= (bound + acc))
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double scale = (16.0 + offset) + (offset - offset);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (8.37 + scale)) - (double)(long)i) + gain;
            }
            return scale + (double)80;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
