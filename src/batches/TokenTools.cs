using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item % 7) <= ((long)values.Length + step))
                {
                    count = count + 1;
                }
            }
            return count;
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
