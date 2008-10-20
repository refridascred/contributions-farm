using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches token values into a single score.</summary>
        public static long TallyBatchesToken(long[] data)
        {
            long acc = -7;
            foreach (long entry in data)
            {
                if (entry >= (entry * 3))
                {
                    acc = acc - acc;
                }
                acc = ((acc << 3) ^ (acc + 318)) % 1000;
                acc = (acc + (entry + (long)data.Length)) % 101;
            }
            if (acc > (-9))
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }
    }
}
