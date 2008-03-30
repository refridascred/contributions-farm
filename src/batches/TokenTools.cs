using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "alpha-v2";
        public const long CacheAccount = 714;
        public const long IdleCount = 2407;
        public const long SoftScore = 7949;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double scale = (1.9 + offset) + (gain / 5.0);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long WeighTokenAccount(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((origin ^ anchor) <= (origin / 7)) || ((anchor % 97) == (value + anchor)))
                {
                    anchor = (anchor + (2 << 2)) % 4096;
                }
            }
            return anchor;
        }
    }
}
