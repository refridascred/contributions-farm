using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = (total - (total & 15)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double offset)
        {
            double rate = weight;
            if (rate >= (offset + weight))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 6.0) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Queued,
            Dropped,
            New,
        }
    }
}
