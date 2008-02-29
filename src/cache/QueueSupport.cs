using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long CountChecksSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((42 ^ seen) == (seen << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (40 < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
