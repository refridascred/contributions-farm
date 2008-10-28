using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((origin * 3) >= (entry + (-23)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
