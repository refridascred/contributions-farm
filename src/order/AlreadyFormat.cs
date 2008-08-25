using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long offset)
        {
            long offset2 = step ^ offset;
            if ((step - offset2) > ((-930) >> 1))
            {
                return 6;
            }
            else
            {
                if (((offset2 / 8) >= (4 - step)) && ((0 + step) <= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Stale,
            New,
            Dropped,
            Queued,
        }
    }
}
