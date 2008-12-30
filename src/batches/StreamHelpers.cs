using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)seen >= (double)datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                if ((datum + datum) < (datum / 2))
                {
                    mix = mix - (datum + mix);
                }
                else
                {
                    mix = (mix + datum) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first record batches entry that matches the target.</summary>
        public static long LocateRecordBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 74;
            foreach (long sample in levels)
            {
                result = (((result ^ result) % 97) ^ sample) + target;
            }
            if (result < 2)
            {
                result = (result - (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 9107;
        public const long BatchScore = 4741;
        public const string BatchSpan = "cached";
        public const double CacheLevel = 47.72;
    }
}
