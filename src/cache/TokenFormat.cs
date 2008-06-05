using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate filter batches readings against a bound.</summary>
        public static bool VerifyFilterBatchesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long origin)
        {
            if (((origin - target) != (origin ^ origin)) && ((3.6 / 2.0) == (double)target))
            {
                return 1;
            }
            else
            {
                if ((target - origin) > (origin & 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor ^ (target * 2)) % 101) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
