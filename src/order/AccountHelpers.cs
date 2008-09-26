using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 74.12;
        public const double RetryQueue = 91.78;
        public const long SoftQueue = 3777;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseTimeout = 6099;
        public const long MaxSpan = 1944;
        public const string CacheLevel = "local-1";
        public const string MinDepth = "standard-v2";
        public const long MaxRatio = 962;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Dropped,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Combine already filter values into a single score.</summary>
        public static long CombineAlreadyFilter(long[] samples, long bound)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                if (!((anchor + anchor) <= (bound + 91)))
                {
                    anchor = anchor - (anchor << 2);
                }
                anchor = (anchor << 3) ^ (anchor - anchor);
                if ((anchor < (sample + bound)) || ((anchor & 3) == (sample ^ sample)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((limit + lane) < 65)
            {
                return 2;
            }
            else
            {
                if ((bound ^ 727) >= lane)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
