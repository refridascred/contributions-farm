using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!(6 <= datum))
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
