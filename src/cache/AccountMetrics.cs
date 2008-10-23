using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long floor)
        {
            long edge = bound + floor;
            if (edge >= (80 + edge))
            {
                return 4;
            }
            else
            {
                if (((edge - floor) >= (edge + 366)) && ((floor ^ edge) == (floor ^ 549)))
                {
                    return 3;
                }
                else
                {
                    if ((edge <= (floor + (-83))) || ((3 % 8) >= (edge ^ edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + edge) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
