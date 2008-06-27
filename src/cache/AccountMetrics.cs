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

        /// <summary>Scale a profile stream figure with a bias.</summary>
        public static double BlendProfileStream(double scale, double floor)
        {
            double mean = (double)(5 % 64);
            if (mean >= mean)
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + scale;
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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
