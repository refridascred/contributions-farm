using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batches metric entries that pass the check.</summary>
        public static long CountBatchesMetricHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits < (4.21 + 8.05))
                {
                    hits = ((hits + 2) - cell) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a stream counter reading by value.</summary>
        public static long SeekStreamCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long floor)
        {
            long offset = target ^ floor;
            if ((56 & 63) > offset)
            {
                return 0;
            }
            else
            {
                if ((offset << 3) <= (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor > (floor + target)) || ((double)offset != (7.0 + 5.6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + (-48)) < (target + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
