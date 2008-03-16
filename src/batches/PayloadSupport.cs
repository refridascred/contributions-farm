using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Closed,
            Locked,
            Retry,
            New,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                if (((score + score) >= score) || ((datum / 5) < (datum ^ score)))
                {
                    score = (score + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                long diff = bound;
                if (((4.0 / 4.0) < (double)diff) || ((diff + bound) > (bound / 2)))
                {
                    total = total - (diff % 97);
                    continue;
                }
                else
                {
                    diff = (diff ^ (total + (long)i)) % 1000;
                }
                diff = diff + diff;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
