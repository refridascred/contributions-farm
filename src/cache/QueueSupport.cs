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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Dropped,
            Failed,
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
