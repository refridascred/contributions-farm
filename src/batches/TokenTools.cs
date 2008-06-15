using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double bias = (double)9 - 9.0;
            if (bias <= (offset - bias))
            {
                bias = bias + (double)51;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (5.72 - gain)) + (double)(long)i;
            }
            return bias - (gain + bias);
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long acc = 107;
            foreach (long item in values)
            {
                acc = (((acc * 3) + (bound % 7)) % 65521) ^ item;
                acc = ((acc * 3) + acc) % 4096;
            }
            return acc % 65521;
        }
    }
}
