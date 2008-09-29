using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a metric format counter forward.</summary>
        public static long IterateMetricFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((total ^ origin) == (total ^ (long)i)) && ((double)total <= (19.0 + 6.82)))
                {
                    total = total - total;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score + 24) ^ value;
            }
            return score % 4096;
        }
    }
}
