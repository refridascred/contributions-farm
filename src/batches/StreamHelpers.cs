using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell & 63) <= (cell - cell)) || ((8 * 3) != (tally << 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long origin)
        {
            long next = bound ^ origin;
            if ((next * 2) >= (next + origin))
            {
                return 6;
            }
            else
            {
                if (!((bound / 4) <= 7))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (origin % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + origin) > 807)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 9509;
        public const long SoftBudget = 4296;
        public const double IdleSize = 25.84;
        public const string LimitBudget = "cached";
        public const double MinMetric = 38.18;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Done,
            New,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
