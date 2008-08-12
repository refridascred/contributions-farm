using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) == (datum * 3))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer tools samples are out of range.</summary>
        public static long MeasureBufferToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((seen / 7) < reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (1.7 * 1.13))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
