using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first graph record entry that matches the target.</summary>
        public static long FindGraphRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples, long floor)
        {
            long acc = 458;
            foreach (long cell in samples)
            {
                if (((long)samples.Length - acc) <= (30 << 1))
                {
                    acc = (((acc << 2) ^ (cell << 2)) % 4096) + floor;
                }
                else
                {
                    acc = (acc - cell) % 4096;
                }
            }
            return acc;
        }
    }
}
