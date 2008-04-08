using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long limit)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark << 2) ^ (limit + (long)i2)) % 4096;
                    mark = mark + (datum % 24);
                }
                if ((limit - mark) >= (limit + limit))
                {
                    mark = (mark << 3) ^ (datum + datum);
                }
                else
                {
                    mark = mark + (limit - 7);
                }
                if (((datum >> 5) <= limit) || ((datum << 3) >= (mark % 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 1743;
        public const long DefaultCount = 9847;
        public const double BatchRoute = 23.31;
        public const double BaseRoute = 8.57;
    }
}
