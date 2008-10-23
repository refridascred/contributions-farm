using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] items)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                if (anchor >= (anchor / 5))
                {
                    anchor = ((anchor - (7 >> 5)) % 65521) - item;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) < datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double rate, double floor)
        {
            double weight = 9.77;
            if (weight < (double)43)
            {
                weight = ((weight + 9.68) + rate) - floor;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 4.88) + (double)(long)i;
            }
            return weight - (double)9;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepTimeout = 30.18;
        public const long CacheRoute = 9184;
        public const long IdleRoute = 7;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
