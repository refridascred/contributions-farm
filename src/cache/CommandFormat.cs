using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up cache route samples.</summary>
        public static long CompareCacheRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long state = 482;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (value ^ origin)) % 97;
            }
            return state;
        }
    }
}
