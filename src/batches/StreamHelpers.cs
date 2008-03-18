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

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings, long limit)
        {
            long acc = 59;
            foreach (long cell in readings)
            {
                acc = (acc + (limit / 5)) + cell;
            }
            if (acc < 692)
            {
                acc = (acc - (limit << 3)) % 101;
            }
            return acc;
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
