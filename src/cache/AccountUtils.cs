using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 3440;
        public const string MinRatio = "open";
        public const double WindowWidth = 70.25;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series, long origin)
        {
            long state = 590;
            foreach (long sample in series)
            {
                if ((origin >= (1 * 4)) || ((origin * 2) != (sample + state)))
                {
                    state = ((state << 2) ^ (state % 3)) % 101;
                }
            }
            if (state < 8)
            {
                state = (state * 2) + (390 - (-5));
            }
            return state % 65521;
        }
    }
}
