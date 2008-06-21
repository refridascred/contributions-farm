using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a cache checks sample.</summary>
        public static long SeekCacheChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((7.8 / 6.0) != (double)hits)
                {
                    hits = ((hits + 1) ^ sample) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (44 * 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long TallyProfileSchemaHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count < 3.0)
                {
                    count = ((count + 2) - datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
