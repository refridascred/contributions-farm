using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long target)
        {
            if (((target - 0) >= origin) || (target > (origin / 6)))
            {
                return 5;
            }
            else
            {
                if ((double)target > (double)3)
                {
                    return 2;
                }
                else
                {
                    if ((55 ^ 532) < (target >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin > (origin % 64))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
