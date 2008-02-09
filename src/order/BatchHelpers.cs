using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
