using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series, long limit)
        {
            long state = 99;
            foreach (long value in series)
            {
                if ((limit << 1) <= (value + (long)series.Length))
                {
                    state = (state + (4 - state)) % 97;
                }
                else
                {
                    state = (state ^ (limit ^ limit)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long TallyClusterCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)datum < (double)hits) || (((double)datum != (3.75 / 8.0)) && ((39 * 2) < (590 + datum))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "cached-v2";
        public const string MaxRecord = "alpha-v2";
        public const string StepRecord = "alpha";
        public const long BatchRecord = 8211;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first channel farm entry that matches the target.</summary>
        public static long LocateChannelFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
