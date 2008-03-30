using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine stats metrics values into a single score.</summary>
        public static long CombineStatsMetrics(long[] series, long seed)
        {
            long anchor = 403;
            foreach (long entry in series)
            {
                if ((double)entry > (9.99 * 2.78))
                {
                    anchor = anchor + (seed - entry);
                    anchor = (anchor - entry) % 101;
                    continue;
                }
                anchor = (anchor * 2) + (63 ^ seed);
            }
            if (anchor > 88)
            {
                anchor = ((anchor << 3) ^ (-47)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Audit channel session readings against a rule.</summary>
        public static long CountChannelSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((15.0 / 7.0) != (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (origin + carry)) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
