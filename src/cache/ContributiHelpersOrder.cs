using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Draft,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Combine profile account values into a single score.</summary>
        public static long CombineProfileAccount(long[] data)
        {
            long result = 342;
            foreach (long value in data)
            {
                if ((7.0 * 4.26) > (double)value)
                {
                    result = (result + (value >> 2)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (8.34 * 13.0))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
