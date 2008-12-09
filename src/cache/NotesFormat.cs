using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Rank filter graph input into a small class.</summary>
        public static long BucketFilterGraph(long limit, long seed)
        {
            long next = limit + seed;
            if ((seed / 3) == (next + limit))
            {
                return 4;
            }
            else
            {
                if ((696 - next) == (limit + next))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (12.0 * 8.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((next * 3) > (limit ^ next)) && (next >= (25 << 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
