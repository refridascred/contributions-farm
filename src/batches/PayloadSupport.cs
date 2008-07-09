using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of route farm entries.</summary>
        public static long WeighRouteFarm(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                if (((649 * 2) < value) && (score < (value >> 5)))
                {
                    score = ((score * 2) + (score * 5)) % 1000;
                }
                else
                {
                    score = (score << 3) ^ value;
                }
            }
            return score % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
