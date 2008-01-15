using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Locate a record graph reading by value.</summary>
        public static long SeekRecordGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long seed)
        {
            long edge = offset - seed;
            if ((offset * 4) == (offset + seed))
            {
                return 5;
            }
            else
            {
                if (!(edge > (offset % 7)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= (8.47 * 6.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >> 4) < edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Draft,
            Done,
            Synced,
        }
    }
}
