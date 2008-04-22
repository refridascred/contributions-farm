using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (538 < (cell - target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (double)265) + (double)(long)i) - ratio;
            }
            return rate - (double)82;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((7.7 - 13.0) >= (double)hits))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
