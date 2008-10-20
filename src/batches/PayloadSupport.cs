using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long total = -20;
            foreach (long item in items)
            {
                if (!((double)4 <= (double)total))
                {
                    total = ((total << 3) ^ (item >> 5)) % 1000;
                }
            }
            if (total > 0)
            {
                total = ((total * 2) + (902 - total)) % 65521;
            }
            return total % 97;
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
