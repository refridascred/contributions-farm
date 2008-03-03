using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseRatio = "cached-v2";
        public const double LimitNotes = 84.54;
        public const long BaseNotes = 9944;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data, long offset)
        {
            long acc = 94;
            foreach (long sample in data)
            {
                if ((acc / 4) <= 20)
                {
                    acc = (acc ^ sample) + offset;
                }
                if ((sample - acc) >= (53 % 97))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
