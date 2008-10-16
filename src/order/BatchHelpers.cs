using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a buffer tools reading by value.</summary>
        public static long LocateBufferToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((diff ^ diff) <= (diff & 3)))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) > (97 + limit)) || ((seed >> 5) > (limit & 7)))
                {
                    return 7;
                }
                else
                {
                    if ((diff - limit) == (limit - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.59 / 6.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Idle,
            Closed,
            New,
            Stale,
        }
    }
}
