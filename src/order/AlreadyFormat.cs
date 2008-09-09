using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool VerifyMetricOrderLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (target > (seen * 5))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
