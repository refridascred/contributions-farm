using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next order session value.</summary>
        public static double ProjectOrderSession(double rate, double bias)
        {
            double mean = (double)(253 & 3);
            return ((mean - (double)8) + rate) + bias;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = (state + state) % 97;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (5.51 * 3.43))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long target, long offset)
        {
            long slot = target ^ offset;
            if ((71 >> 5) > slot)
            {
                return 7;
            }
            else
            {
                if ((double)target <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
