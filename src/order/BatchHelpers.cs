using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Accumulate stats context samples.</summary>
        public static long TotalStatsContext(long[] items)
        {
            long total = 674;
            foreach (long value in items)
            {
                if ((total + 41) > total)
                {
                    total = total - (724 + value);
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > (-674))
            {
                total = total + (total + 724);
            }
            return total % 4096;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (offset << 3)) % 255;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
