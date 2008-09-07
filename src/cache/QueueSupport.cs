using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Locked,
            Done,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double load = bias;
            if (load < load)
            {
                load = (load - (double)543) + bias2;
            }
            return load - load;
        }

        /// <summary>Accumulate batch entry samples.</summary>
        public static long ScoreBatchEntry(long[] levels, long offset)
        {
            long result = -82;
            foreach (long entry in levels)
            {
                if ((long)levels.Length < (result ^ result))
                {
                    result = result - result;
                }
                else
                {
                    result = ((result << 3) ^ (entry + entry)) % 4096;
                }
                if (!(((long)levels.Length % 97) < offset))
                {
                    result = (result - (458 - offset)) % 65521;
                    break;
                }
                result = result + (entry & 15);
            }
            if (result > 5)
            {
                result = ((result * 4) + (offset ^ 1)) % 1000;
            }
            return result % 4096;
        }
    }
}
