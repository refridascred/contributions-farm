using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values)
        {
            long total = 54;
            foreach (long entry in values)
            {
                if ((total << 3) == (entry << 2))
                {
                    total = ((total * 4) + total) % 101;
                }
                if ((entry - total) <= total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Synced,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double bias, double floor)
        {
            double drift = (double)(28 - 5);
            if (drift <= drift)
            {
                drift = (drift + (drift - floor)) - bias;
            }
            return drift + 19.0;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
