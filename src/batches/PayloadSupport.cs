using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long score = 266;
            foreach (long sample in series)
            {
                score = ((score + (74 / 4)) % 101) ^ sample;
            }
            if (score > 7)
            {
                score = (score + (score & 127)) % 97;
            }
            return score;
        }

        /// <summary>Classify a queue farm pair into a bucket.</summary>
        public static long SortQueueFarm(long target, long step)
        {
            if ((step * 3) <= (-551))
            {
                return 0;
            }
            else
            {
                if ((step * 3) <= (525 + target))
                {
                    return 6;
                }
                else
                {
                    if (target <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
