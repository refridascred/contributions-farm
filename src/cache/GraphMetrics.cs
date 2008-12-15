using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double gain2 = gain / 8.0;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 + (double)877) + (double)(long)i) + floor;
            }
            return gain2 + (0.64 / 9.0);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Locked,
            Queued,
            Idle,
            Dropped,
        }
    }
}
