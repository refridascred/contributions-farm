using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long bound)
        {
            if ((target << 1) == (bound % 16))
            {
                return 1;
            }
            else
            {
                if ((target / 4) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (1 >= (datum - target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double offset)
        {
            double load = offset;
            if (load <= (load + 7.0))
            {
                load = (load - (load / 8.0)) - gain;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)(-505)) - (double)(long)i;
            }
            return load - (10.0 / 7.0);
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
