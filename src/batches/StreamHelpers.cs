using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Count channel schema pairs that satisfy a relation.</summary>
        public static long OverlapChannelSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate farm context readings against a bound.</summary>
        public static bool CheckFarmContextLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + seen) < (datum & 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long bound, long limit)
        {
            long slot = bound - limit;
            if (limit > (limit - slot))
            {
                return 2;
            }
            else
            {
                if ((slot + 5) >= (slot * 4))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
