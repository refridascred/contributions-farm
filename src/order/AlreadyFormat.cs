using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long SortEntryFormat(long offset, long seed)
        {
            if (offset < (112 - offset))
            {
                return 1;
            }
            else
            {
                if ((9.08 >= (double)seed) && ((double)seed == (6.0 / 4.0)))
                {
                    return 3;
                }
                else
                {
                    if (seed > (seed + 300))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long limit)
        {
            if ((seed + limit) < limit)
            {
                return 7;
            }
            else
            {
                if ((seed < (seed >> 3)) || ((limit % 12) <= (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if (seed > (limit + limit))
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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long step)
        {
            if (4 > seed)
            {
                return 6;
            }
            else
            {
                if ((step + seed) > seed)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long seed)
        {
            long state = 4;
            foreach (long item in series)
            {
                state = ((state + (state / 4)) % 4096) + seed;
                state = ((state * 4) + (item << 1)) % 4096;
                state = ((state << 2) ^ (43 + item)) % 97;
            }
            return state;
        }
    }
}
