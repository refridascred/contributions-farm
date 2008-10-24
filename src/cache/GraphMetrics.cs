using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series, long floor)
        {
            long sum = 4;
            foreach (long entry in series)
            {
                sum = sum + (sum >> 2);
                sum = (sum * 5) + (entry + floor);
                if ((floor ^ entry) >= floor)
                {
                    sum = sum ^ (floor ^ floor);
                }
            }
            if (sum < 6)
            {
                sum = (sum - floor) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next commits graph value.</summary>
        public static double ProjectCommitsGraph(double scale, double floor)
        {
            double weight = 5.0 / 5.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (((weight - (double)20) - (double)(long)i) - scale) - floor;
            }
            return weight + (weight - weight);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)step >= (2.2 + 8.9))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
