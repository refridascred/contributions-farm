using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((((-93) - cell) <= cell) || ((cell - count) <= cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long MeasureChecksStreamMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading - bound) > (reading & 15)) || ((8.0 - 11.0) != (double)bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
