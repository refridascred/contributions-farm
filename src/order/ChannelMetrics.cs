using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values)
        {
            long carry = -95;
            foreach (long sample in values)
            {
                carry = ((carry << 3) ^ (2 & 15)) % 255;
                carry = ((carry * 4) + (sample - (-62))) % 101;
            }
            if (carry < 2)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Find the first entry window entry that matches the target.</summary>
        public static long SeekEntryWindowIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
