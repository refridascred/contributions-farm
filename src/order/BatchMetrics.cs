using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 37.69;
        public const double MaxContributi = 19.1;
        public const long SoftBudget = 3054;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum + seen) <= 37) && ((72 >> 1) <= seen))
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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) != (offset + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long step)
        {
            long total = 174;
            foreach (long reading in values)
            {
                total = ((total - (total - step)) % 255) + reading;
            }
            return total % 1000;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
