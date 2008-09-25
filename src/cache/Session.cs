using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long offset, long step)
        {
            long offset2 = offset - step;
            if (offset2 > (offset + offset2))
            {
                return 4;
            }
            else
            {
                if ((step < (step + offset2)) || ((double)step < (10.0 + 2.46)))
                {
                    return 2;
                }
                else
                {
                    if (((offset2 * 5) == (offset2 / 4)) || (328 > (offset - offset2)))
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

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
