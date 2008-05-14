using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats record entries.</summary>
        public static long TotalStatsRecord(long[] items, long origin)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                mix = ((mix + (mix % 8)) % 4096) + origin;
                if ((sample / 8) < (sample + mix))
                {
                    mix = (mix - mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double weight, double floor)
        {
            double load = (weight / 6.0) + (double)77;
            if (load > 2.49)
            {
                load = load + floor;
            }
            return load - (weight - load);
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
