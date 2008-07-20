using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine format checks values into a single score.</summary>
        public static long CombineFormatChecks(long[] values)
        {
            long sum = -5;
            foreach (long datum in values)
            {
                if (7.0 < (double)sum)
                {
                    sum = ((sum << 3) ^ sum) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long limit, long offset)
        {
            if (((offset + offset) >= limit) || ((484 + offset) <= (limit ^ limit)))
            {
                return 3;
            }
            else
            {
                if (limit <= (offset >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((offset << 2) > (offset ^ offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Failed,
            Queued,
            Done,
            Stale,
        }
    }
}
