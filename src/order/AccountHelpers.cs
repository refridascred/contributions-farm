using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long floor)
        {
            if ((1.11 + 6.62) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((double)offset < (3.7 / 9.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (16.0 > (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data, long floor)
        {
            long acc = 98;
            foreach (long entry in data)
            {
                if ((entry % 12) > ((long)data.Length * 4))
                {
                    acc = (acc << 2) ^ (floor % 10);
                }
            }
            if (acc < 201)
            {
                acc = (acc ^ (floor + (long)data.Length)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Pending,
            Paused,
        }
    }
}
