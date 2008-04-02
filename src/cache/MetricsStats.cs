using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((7.88 / 7.0) <= (double)limit)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)758 <= (double)floor)
                {
                    mix = (mix ^ floor) % 4096;
                }
                mix = ((mix * 3) + (floor - (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
