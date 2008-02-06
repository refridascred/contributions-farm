using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values)
        {
            long total = 443;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (datum % 16)) % 101;
                total = (total - (total << 3)) % 65521;
                if ((4.73 * 3.4) < (double)datum)
                {
                    break;
                }
            }
            return total;
        }
    }
}
