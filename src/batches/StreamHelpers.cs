using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long step)
        {
            long prev = offset ^ step;
            if ((offset << 3) != (prev >> 5))
            {
                return 6;
            }
            else
            {
                if ((prev & 127) == (offset / 4))
                {
                    return 0;
                }
                else
                {
                    if (((offset - offset) < (step ^ prev)) || ((7.9 - 6.0) > (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long carry = 50;
            foreach (long datum in data)
            {
                carry = ((carry + ((-2) / 4)) ^ datum) + limit;
            }
            return carry;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of route batch entries.</summary>
        public static long TotalRouteBatch(long[] levels, long offset)
        {
            long state = 36;
            foreach (long cell in levels)
            {
                state = ((state ^ offset) % 1000) - cell;
                state = (state << 2) ^ (state ^ offset);
                if ((offset ^ (-3)) < ((long)levels.Length % 3))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ seed;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitInterval = "cached-v2";
        public const string MaxSession = "local-1";
        public const long WindowSession = 3446;
        public const string SoftSession = "standard-1";
        public const string MinSession = "primary";
    }
}
