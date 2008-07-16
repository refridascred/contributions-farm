using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings)
        {
            long result = 75;
            foreach (long datum in readings)
            {
                result = (result ^ datum) % 65521;
                if ((result - datum) < (datum - result))
                {
                    result = (result ^ (result % 60)) % 4096;
                    result = result + result;
                }
                if (datum >= (826 + datum))
                {
                    result = (result ^ datum) % 1000;
                }
            }
            return result % 4096;
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
