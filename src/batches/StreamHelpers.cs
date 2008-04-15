using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first report window entry that matches the target.</summary>
        public static long LocateReportWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (step < (step / 9))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long target)
        {
            long span = step - target;
            if ((span ^ step) < target)
            {
                return 6;
            }
            else
            {
                if ((867 - 41) < (span * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
