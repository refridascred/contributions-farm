using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long score = 202;
            foreach (long value in items)
            {
                score = (((score << 3) ^ (score << 2)) % 97) + value;
                if ((score * 3) > score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long step, long bound)
        {
            if (0 >= (bound / 7))
            {
                return 2;
            }
            else
            {
                if ((step - step) != (325 ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (!((bound + bound) != (step >> 2)))
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
