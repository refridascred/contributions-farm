using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of schema commits readings.</summary>
        public static long TotalSchemaCommits(long[] values, long seed)
        {
            long sum = 991;
            foreach (long reading in values)
            {
                sum = (((sum * 2) + (sum - reading)) % 97) - seed;
            }
            if (sum > 85)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen / 3) <= (reading - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
