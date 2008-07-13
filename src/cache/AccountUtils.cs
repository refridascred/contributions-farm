using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long floor)
        {
            if ((522 - bound) == ((-4) * 4))
            {
                return 0;
            }
            else
            {
                if (bound < (bound % 10))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 9242;
        public const long DefaultFactor = 6433;
        public const long IdleAlready = 5434;
        public const double MinAlready = 54.52;
        public const long BaseAlready = 1206;

        /// <summary>Iterate the batches layout series from a seed.</summary>
        public static long DeriveBatchesLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + ((long)i % 16)) % 255;
                anchor = (anchor - (anchor * 2)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
