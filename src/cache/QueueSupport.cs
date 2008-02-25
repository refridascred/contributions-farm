using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long limit)
        {
            long diff = floor + limit;
            if (((limit ^ floor) == (limit + diff)) && ((double)floor >= (double)37))
            {
                return 6;
            }
            else
            {
                if ((9.2 * 9.0) != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (((floor - floor) <= (limit % 60)) && ((limit << 1) <= (diff / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
