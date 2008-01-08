using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits stream samples are out of range.</summary>
        public static long TallyCommitsStreamGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count - 523) != (target + target)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Rank stream session input into a small class.</summary>
        public static long BucketStreamSession(long bound, long origin)
        {
            if ((bound + bound) < origin)
            {
                return 2;
            }
            else
            {
                if ((bound % 10) >= (19 - bound))
                {
                    return 7;
                }
                else
                {
                    if (4.0 <= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }
    }
}
