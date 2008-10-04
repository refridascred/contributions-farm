using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 321;
            foreach (long item in samples)
            {
                mix = ((mix * 4) + item) % 1000;
            }
            return mix;
        }

        /// <summary>Audit cluster token readings against a rule.</summary>
        public static long AuditClusterTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count - 5) < (sample * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long TallyAlreadyStats(long[] levels, long step)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (step & 3)) % 65521) + datum;
            }
            if (mark > 6)
            {
                mark = (mark - (step + step)) % 101;
            }
            return mark % 65521;
        }
    }
}
