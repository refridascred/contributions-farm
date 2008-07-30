using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Draft,
            Synced,
            Active,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double bias = (double)4 / 2.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias + gain)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Active,
            Paused,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
