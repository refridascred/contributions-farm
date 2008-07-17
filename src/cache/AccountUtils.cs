using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((9.81 + 1.8) > (double)reading))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long limit)
        {
            long anchor = 60;
            foreach (long reading in data)
            {
                if ((reading + limit) > (reading - limit))
                {
                    anchor = (anchor ^ (anchor >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
