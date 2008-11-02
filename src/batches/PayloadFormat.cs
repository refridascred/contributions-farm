using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the support editor entries that pass the check.</summary>
        public static long AuditSupportEditorOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (double)count)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((0 & 3) == (long)data.Length)
                {
                    seen = ((seen + 2) ^ item) + offset;
                }
            }
            return seen;
        }
    }
}
