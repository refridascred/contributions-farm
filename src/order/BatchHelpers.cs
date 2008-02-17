using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter context samples are out of range.</summary>
        public static long AuditFilterContextGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally < (double)step)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
