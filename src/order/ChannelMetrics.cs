using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long result = 715;
            foreach (long reading in series)
            {
                if (!((result + 6) <= result))
                {
                    result = ((result + (result % 64)) % 65521) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Derive the next record buffer value from a seed.</summary>
        public static long RollRecordBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (result / 6)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Synced,
            Closed,
        }
    }
}
