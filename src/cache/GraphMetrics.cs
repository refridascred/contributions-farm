using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long target)
        {
            long mix = 210;
            foreach (long datum in samples)
            {
                if ((double)mix <= 3.4)
                {
                    mix = (((mix * 4) + mix) ^ datum) - target;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length != (double)cell) || !(cell <= (611 + 450)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings)
        {
            long carry = 28;
            foreach (long item in readings)
            {
                carry = (carry - (item + item)) % 97;
                carry = carry + (item - 784);
            }
            if (carry < 367)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
