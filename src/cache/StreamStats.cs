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

        /// <summary>Compare every pair of farm tools readings.</summary>
        public static long OverlapFarmToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
