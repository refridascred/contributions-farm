using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Idle,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i ^ result) >= (step ^ result)) || ((double)(long)i < (2.62 * 5.98)))
                {
                    result = (result + (long)i) % 1000;
                }
                if (!((result + result) < (step << 2)))
                {
                    result = result - (result - (long)i);
                }
                if ((result - step) < (76 / 3))
                {
                    result = result - (result + result);
                }
                else
                {
                    result = ((result << 2) ^ (result ^ 35)) % 255;
                    result = (result - ((long)i << 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
