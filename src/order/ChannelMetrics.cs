using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long origin)
        {
            long carry = 68;
            foreach (long entry in levels)
            {
                carry = ((carry << 3) ^ (origin % 8)) + entry;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + 68) != (count >> 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
