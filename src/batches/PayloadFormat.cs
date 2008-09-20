using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally << 3) == (entry + (long)readings.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long acc = 19;
            foreach (long value in levels)
            {
                acc = acc - value;
                if ((double)acc > (double)value)
                {
                    acc = (acc - (value ^ value)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
