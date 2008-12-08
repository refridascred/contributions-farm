using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long anchor = -6;
            foreach (long item in values)
            {
                anchor = (anchor << 3) ^ (12 + floor);
                if (266 >= (anchor + floor))
                {
                    anchor = anchor - (item - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(seed > (7 + 767)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long acc = 753;
            foreach (long value in items)
            {
                if (((bound + (long)items.Length) >= value) || ((acc + acc) < (38 * 3)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double drift = gain;
            if (drift > (drift / 4.0))
            {
                drift = drift - 3.0;
            }
            return drift - span;
        }

        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((43 >> 2) == (hits & 7))
                {
                    hits = ((hits + 3) ^ reading) + step;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 6.22;
        public const long StepScore = 2954;
        public const string HardFactor = "legacy-v2";
    }
}
