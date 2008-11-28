using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series, long bound)
        {
            long anchor = 426;
            foreach (long entry in series)
            {
                anchor = (anchor - (entry & 7)) + bound;
                if ((4.56 - 2.0) > (double)anchor)
                {
                    anchor = anchor + (91 >> 4);
                }
                else
                {
                    anchor = (anchor ^ 569) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits / 2) <= (datum & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two support payload measurements.</summary>
        public static double AdjustSupportPayload(double bias, double bias2)
        {
            double rate = bias2 + bias2;
            if (rate < (rate - bias2))
            {
                rate = (rate - (double)(-86)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 0.52) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double bias = (gain / 3.0) - span;
            if (bias > (bias / 4.0))
            {
                bias = bias - (double)437;
            }
            else
            {
                bias = bias - (gain - bias);
            }
            return bias + span;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                state = ((state * 5) + (81 ^ 6)) % 97;
                state = (state + item) % 97;
            }
            return state;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }
    }
}
