using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long limit)
        {
            if (((origin % 7) >= (origin & 31)) && (limit >= (limit & 1)))
            {
                return 3;
            }
            else
            {
                if (limit <= (limit & 127))
                {
                    return 1;
                }
                else
                {
                    if (limit < (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit <= (origin - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item >= (3.6 / 4.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
