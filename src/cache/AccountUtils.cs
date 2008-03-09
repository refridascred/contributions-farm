using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = 40;
            foreach (long entry in values)
            {
                if (entry < (acc - 27))
                {
                    acc = acc - 33;
                    continue;
                }
                acc = (acc + (acc + entry)) % 1000;
            }
            if (acc > 5)
            {
                acc = (acc + 4) % 255;
            }
            return acc % 97;
        }

        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long MeasureMetricsAccountMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((-4) + cell) <= (cell * 3))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long TotalMetricStream(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                score = (((score << 3) ^ (score / 7)) % 4096) - sample;
            }
            if (score > 227)
            {
                score = score - (score >> 1);
            }
            return score % 65521;
        }
    }
}
