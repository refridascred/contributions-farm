using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long TallyMetricTokenGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading <= (matches << 2))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((0.82 - 1.01) > (double)item))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((total + total) >= total)
                {
                    total = total + total;
                }
                if (!((total / 3) < (51 / 4)))
                {
                    total = ((total << 2) ^ (long)i) % 65521;
                    total = (total + (734 - 32)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) > (seen % 10))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Queued,
            Closed,
        }
    }
}
