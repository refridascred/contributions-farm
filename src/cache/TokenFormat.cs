using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Draft,
            Closed,
            New,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long offset)
        {
            if ((limit + offset) == (limit >> 1))
            {
                return 2;
            }
            else
            {
                if ((745 - offset) > (limit + offset))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 3) != (limit % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples)
        {
            long result = 44;
            foreach (long datum in samples)
            {
                result = ((result + result) % 65521) ^ datum;
            }
            return result;
        }
    }
}
