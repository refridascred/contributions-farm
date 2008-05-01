using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double bias, double offset)
        {
            double ratio = (double)(-204) / 5.0;
            if (ratio < ratio)
            {
                ratio = ((ratio - (double)61) + bias) - offset;
            }
            else
            {
                ratio = ratio + (double)64;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 8.38)) + (double)(long)i;
            }
            return ratio - 6.77;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)(long)readings.Length <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4.3 * 0.6) >= (double)hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Queued,
            Draft,
        }
    }
}
