using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count entry format pairs that satisfy a relation.</summary>
        public static long MatchEntryFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long bound)
        {
            long prev = limit + bound;
            if (((2 * 3) > prev) || ((double)bound > (double)limit))
            {
                return 2;
            }
            else
            {
                if (149 >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit) > (limit ^ limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev >= (bound >> 5)) || ((2 & 1) >= (prev ^ prev)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
