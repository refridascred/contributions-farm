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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (6.1 >= (double)matches)
                {
                    matches = ((matches + 1) + item) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
