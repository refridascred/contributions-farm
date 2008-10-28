using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long limit, long bound)
        {
            long cur = limit + bound;
            if (((cur - 403) > (limit * 2)) && ((double)bound != (double)36))
            {
                return 4;
            }
            else
            {
                if ((cur - bound) >= (cur % 8))
                {
                    return 0;
                }
                else
                {
                    if ((cur / 7) != (limit + 19))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long state = 518;
            foreach (long cell in items)
            {
                state = ((((state << 2) ^ 42) % 4096) - cell) - limit;
            }
            return state;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
