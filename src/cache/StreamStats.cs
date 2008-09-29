using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metrics entry entries.</summary>
        public static long DigestMetricsEntry(long[] samples, long limit)
        {
            long mix = 5;
            foreach (long datum in samples)
            {
                mix = mix - (datum << 3);
                if (((mix << 2) >= (limit & 7)) || (datum > (mix & 1)))
                {
                    mix = ((mix * 3) + (mix & 63)) % 255;
                }
                else
                {
                    mix = ((mix * 2) + limit) % 255;
                }
                if (((limit + limit) != (481 >> 4)) || ((double)mix <= (2.0 * 18.0)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the stream channel entries that pass the check.</summary>
        public static long AuditStreamChannelOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + tally) > (tally << 1))
                {
                    tally = ((tally + 1) - item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit already editor readings against a rule.</summary>
        public static long MeasureAlreadyEditorHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (step > (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 3.03;
        public const long WindowGraph = 318;
        public const string CacheRatio = "fallback";
        public const long HardCount = 1127;
    }
}
