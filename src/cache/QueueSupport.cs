using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token graph samples are out of range.</summary>
        public static long CountTokenGraphOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum % 97) > (5 + count))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Dropped,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
