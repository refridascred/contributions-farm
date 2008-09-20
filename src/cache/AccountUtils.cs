using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long seed)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                if (!((877 % 100) <= (seed * 5)))
                {
                    mix = ((mix * 2) + (9 / 5)) ^ item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double weight = (double)800 / 6.0;
            if (weight >= (weight - 8.5))
            {
                weight = ((weight - weight) - scale) + span;
            }
            return weight - (double)582;
        }
    }
}
