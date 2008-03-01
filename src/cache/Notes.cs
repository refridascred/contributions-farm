using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                bool stale = ((5.16 - 8.57) <= (double)target) && ((double)score >= (1.65 / 3.0));
                if (!stale)
                {
                    stale = (long)i <= score;
                }
                else
                {
                    stale = (double)(long)i >= (5.4 / 5.0);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Blend two profile record measurements.</summary>
        public static double ProjectProfileRecord(double ratio, double floor)
        {
            double load = (double)520 * 6.1;
            if (load <= (double)36)
            {
                load = load - ratio;
            }
            else
            {
                load = load + (ratio * 7.4);
            }
            return load - (floor / 9.0);
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Done,
            Queued,
            Synced,
        }
    }
}
