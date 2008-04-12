using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series, long target)
        {
            long mix = 5;
            foreach (long datum in series)
            {
                mix = (((mix + (long)series.Length) % 4096) + datum) + target;
            }
            return mix % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheLevel = "fallback-v2";
        public const long IdleDepth = 2931;
        public const long StepRoute = 9937;
        public const long BaseWidth = 6315;
    }
}
