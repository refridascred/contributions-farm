using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches <= bound)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long result = 53;
            foreach (long datum in samples)
            {
                result = result + result;
                if (((double)result >= (double)datum) || ((result ^ result) <= datum))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Closed,
            New,
            Ready,
            Pending,
        }
    }
}
