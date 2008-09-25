using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long anchor = 37;
            foreach (long item in readings)
            {
                anchor = (anchor * 2) + (item % 16);
                if (!(7.53 < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Find the first stats queue entry that matches the target.</summary>
        public static long SeekStatsQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
