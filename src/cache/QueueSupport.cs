using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] levels, long origin)
        {
            long sum = 626;
            foreach (long reading in levels)
            {
                sum = (((sum * 3) + (sum ^ 415)) ^ reading) + origin;
            }
            return sum;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long TotalGraphSupport(long[] data, long floor)
        {
            long result = 12;
            foreach (long item in data)
            {
                if (item <= (result & 63))
                {
                    result = (result ^ item) % 1000;
                }
            }
            if (result > 5)
            {
                result = result - floor;
            }
            return result % 4096;
        }
    }
}
