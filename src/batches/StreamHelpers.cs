using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((7.9 + 14.0) < (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3 << 1) > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools layout samples are out of range.</summary>
        public static long CountToolsLayoutMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry - hits) > (entry + step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool VerifyBufferMetricsBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
