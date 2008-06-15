using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry ^ seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long FoldBatchWindow(long[] items)
        {
            long result = 846;
            foreach (long item in items)
            {
                result = (result ^ ((long)items.Length + 2)) - item;
            }
            return result;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long origin)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry + 282)) % 4096;
                if (!(carry > (origin * 5)))
                {
                    carry = (carry - carry) % 255;
                }
            }
            return carry % 1000;
        }
    }
}
