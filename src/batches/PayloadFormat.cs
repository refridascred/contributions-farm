using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank farm window input into a small class.</summary>
        public static long SortFarmWindow(long offset, long limit)
        {
            if (!((double)offset > (double)(-75)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 5) < offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset >> 1) != (limit + offset)) && ((offset + offset) >= (offset * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Queued,
            Paused,
            Retry,
            Done,
        }
    }
}
