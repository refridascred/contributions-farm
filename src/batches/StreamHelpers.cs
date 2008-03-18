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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Retry,
            New,
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
