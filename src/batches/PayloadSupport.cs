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

        /// <summary>Iterate the order entry series from a seed.</summary>
        public static long SeriesOrderEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
