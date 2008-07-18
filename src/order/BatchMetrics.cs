using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double load = scale;
            if (load < scale)
            {
                load = (load + (scale * 14.0)) - span;
            }
            else
            {
                load = load + (2.2 - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 6.3) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((-26) + tally) < (tally + tally))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheSpan = 57.09;
        public const double IdleDepth = 35.45;
        public const string MinInterval = "primary-1";

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a counter cache reading by value.</summary>
        public static long LookupCounterCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi order value.</summary>
        public static double AdjustContributiOrder(double ratio, double floor)
        {
            double weight = floor;
            if (weight < ratio)
            {
                weight = weight + 4.0;
            }
            else
            {
                weight = weight - (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
