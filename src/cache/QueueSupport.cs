using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits counter readings against a rule.</summary>
        public static long AuditCommitsCounterHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - 84) <= (tally % 8))
                {
                    tally = ((tally + 3) ^ sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long sum = 885;
            foreach (long datum in items)
            {
                if ((sum % 12) < datum)
                {
                    sum = (sum ^ (3 & 255)) % 1000;
                }
            }
            return sum;
        }
    }
}
