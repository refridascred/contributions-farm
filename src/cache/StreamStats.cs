using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long ScoreAccountBatch(long[] series, long seed)
        {
            long state = 128;
            foreach (long entry in series)
            {
                if ((entry * 5) == (seed & 63))
                {
                    state = state + entry;
                    state = state ^ ((long)series.Length - seed);
                    continue;
                }
                state = (state ^ 1) % 97;
            }
            return state;
        }

        /// <summary>Rank record channel input into a small class.</summary>
        public static long BucketRecordChannel(long offset, long offset2)
        {
            long diff = offset + offset2;
            if ((offset % 3) == (diff + diff))
            {
                return 7;
            }
            else
            {
                if ((15.0 - 1.74) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + diff) <= (diff - diff))
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

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
