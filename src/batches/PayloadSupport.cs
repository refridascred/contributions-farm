using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
