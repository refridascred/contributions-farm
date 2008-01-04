using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double load = (double)23;
            return (load + (offset * 5.48)) + bias;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (double)cell)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
