using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session record series from a seed.</summary>
        public static long IterateSessionRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((8.4 - 19.0) > (double)(long)i)
                {
                    acc = (acc << 2) ^ (offset ^ acc);
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ 3) % 97;
                    acc = (acc ^ (long)i) % 65521;
                }
                acc = (acc << 2) ^ (124 - acc);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate batches filter readings against a bound.</summary>
        public static bool GuardBatchesFilterLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
