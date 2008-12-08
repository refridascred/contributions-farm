using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long acc = 836;
            foreach (long item in data)
            {
                if ((item % 100) <= acc)
                {
                    acc = (((acc * 4) + 61) % 65521) - limit;
                }
                acc = (acc * 3) + ((long)data.Length + 597);
                if (320 < (item << 2))
                {
                    acc = ((acc * 5) + (744 + 9)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
