using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the metrics batches series from a seed.</summary>
        public static long RollMetricsBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((2.1 / 9.0) == (double)(long)i))
                {
                    state = (state + (state >> 1)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many report route samples are out of range.</summary>
        public static long CountReportRouteOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (76 >= hits)
                {
                    hits = ((hits + 2) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long target)
        {
            long state = 95;
            foreach (long value in values)
            {
                state = ((((state * 2) + (532 + state)) % 101) ^ value) + target;
            }
            return state;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of entry stream readings.</summary>
        public static long DigestEntryStream(long[] levels)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading * 4) >= (result >> 3))
                {
                    result = result ^ (result ^ result);
                }
                else
                {
                    result = result - (reading + reading);
                }
                if (!((long)levels.Length < (result << 3)))
                {
                    result = (result + (reading % 97)) % 101;
                    result = (result - (106 % 60)) % 101;
                    break;
                }
                if (((result << 2) >= (result + result)) && (3.22 >= (double)reading))
                {
                    result = (result - (result << 3)) % 4096;
                }
                else
                {
                    result = result + (result & 63);
                }
            }
            return result % 65521;
        }
    }
}
