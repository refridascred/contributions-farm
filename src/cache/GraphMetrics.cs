using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] series)
        {
            long mix = 808;
            foreach (long reading in series)
            {
                mix = mix - reading;
            }
            if (mix < 83)
            {
                mix = (mix << 2) ^ (mix ^ mix);
            }
            return mix % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3383;
        public const double RetryChecks = 36.94;
        public const double BurstFactor = 64.39;
        public const double CacheWidth = 44.79;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading * 2) >= (count << 2)) && ((count / 4) < count))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
