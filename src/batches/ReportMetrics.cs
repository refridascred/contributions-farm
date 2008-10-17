using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(((floor + carry) > carry) && ((long)i >= floor)))
                {
                    carry = carry ^ (291 % 7);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((bound - 66) == (hits >> 4))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
