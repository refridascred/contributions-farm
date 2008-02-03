using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next payload record value from a seed.</summary>
        public static long SeriesPayloadRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix + (bound + bound)) % 1000;
                mix = (mix - (mix - (long)i)) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = span;
            if (ratio < rate)
            {
                ratio = ratio + (9.06 * 8.7);
            }
            return ratio + (double)59;
        }

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length >= (9.83 / 9.0)) && ((seen >> 2) < 9))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
