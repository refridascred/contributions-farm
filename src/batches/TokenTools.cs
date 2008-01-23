using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long total = -45;
            foreach (long entry in levels)
            {
                total = ((total * 3) + (entry + entry)) % 1000;
                total = (total ^ (entry * 5)) % 65521;
            }
            if (total < 0)
            {
                total = total ^ (-7);
            }
            return total;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - 92) != (hits + (-857)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Queued,
            Pending,
            Draft,
        }
    }
}
