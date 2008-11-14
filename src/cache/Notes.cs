using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long bound)
        {
            if (!((double)bound > 9.0))
            {
                return 8;
            }
            else
            {
                if (!((bound % 97) == (795 - 2)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long origin)
        {
            long mark = 807;
            foreach (long reading in items)
            {
                if (!((origin * 4) > (origin + mark)))
                {
                    mark = ((mark ^ (origin << 1)) % 65521) - reading;
                }
                else
                {
                    mark = (mark * 2) + (origin << 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading - reading) > (reading ^ reading)) || ((count * 4) != (reading + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
