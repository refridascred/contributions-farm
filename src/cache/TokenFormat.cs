using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
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
