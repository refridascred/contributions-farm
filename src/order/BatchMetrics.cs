using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long DeriveFormatSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen <= (datum << 2)) && ((double)seen < 7.75))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Paused,
            Draft,
            Failed,
            Pending,
        }
    }
}
