using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double weight = (double)(-7) * 9.56;
            if (weight <= (weight / 3.0))
            {
                weight = ((weight + (double)295) - scale) + bias;
            }
            else
            {
                weight = weight - (18.0 / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (10.0 / 6.0)) - (double)(long)i;
            }
            return weight - weight;
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

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
