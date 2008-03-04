using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (112 < count)
                {
                    count = ((count + 1) ^ item) + seed;
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long origin)
        {
            long delta = floor - origin;
            if ((floor << 3) >= (floor + origin))
            {
                return 4;
            }
            else
            {
                if (origin > (delta + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin >= (5 ^ 19)) && ((double)floor <= (0.49 * 6.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor > (delta - origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((6.46 / 3.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
