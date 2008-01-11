using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the command format entries that pass the check.</summary>
        public static long MeasureCommandFormatGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + target) > entry) && (count <= (target % 100)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
