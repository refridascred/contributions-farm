using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 6966;
        public const string BatchSize = "staging-1";
        public const long BurstSchema = 5481;
        public const string BatchFactor = "open-edge";
        public const double BatchSchema = 77.35;

        /// <summary>Accumulate contributi entry samples.</summary>
        public static long TotalContributiEntry(long[] values, long bound)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (((mix - (mix * 4)) % 65521) ^ value) + bound;
            }
            return mix % 1000;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] values, long bound)
        {
            long carry = 0;
            foreach (long value in values)
            {
                if ((double)carry <= (double)value)
                {
                    carry = ((carry << 3) ^ (bound / 8)) % 4096;
                }
                else
                {
                    carry = (carry - (826 ^ bound)) % 101;
                }
            }
            if (carry < 637)
            {
                carry = ((carry * 2) + (341 & 7)) % 1000;
            }
            return carry;
        }
    }
}
