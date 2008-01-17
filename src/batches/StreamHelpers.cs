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

        /// <summary>Derive the next contributi stats value from a seed.</summary>
        public static long IterateContributiStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + ((long)i << 2)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Check that every record farm entry stays within the limit.</summary>
        public static bool CheckRecordFarmBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
