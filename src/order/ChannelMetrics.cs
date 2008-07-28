using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseBudget = "local-edge";
        public const string IdleInterval = "open-edge";
        public const string CacheScore = "stable-1";

        /// <summary>Audit metric format readings against a rule.</summary>
        public static long TallyMetricFormatGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading - matches) > (matches + matches))
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
