using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryTimeout = 5.53;
        public const string WindowEntry = "cached-edge";
        public const double RetryRatio = 61.53;
        public const double LimitSize = 9.94;

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long state = 14;
            foreach (long reading in readings)
            {
                state = (((state << 3) ^ (bound + 66)) % 4096) ^ reading;
                if ((bound * 3) >= bound)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
