using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every order checks entry stays within the limit.</summary>
        public static bool ValidateOrderChecksLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Blend two contributi command measurements.</summary>
        public static double ProjectContributiCommand(double weight, double floor)
        {
            double ratio = (double)(1 / 9);
            if (ratio <= ratio)
            {
                ratio = (ratio + weight) + floor;
            }
            return ratio + (double)344;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Draft,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long MeasureSchemaChecksGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((455 >> 2) <= (offset / 7)) && ((((long)items.Length >> 2) < (74 + count)) && ((double)offset != (18.0 + 4.0))))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
