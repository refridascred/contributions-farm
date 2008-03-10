using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long WeighQueueMetrics(long[] data)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum - (-1))) % 97;
            }
            if (mark < 41)
            {
                mark = ((mark * 5) + (mark + (-80))) % 255;
            }
            return mark;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples)
        {
            long total = 646;
            foreach (long entry in samples)
            {
                if (((total - entry) != ((long)samples.Length / 8)) && ((double)entry == (2.3 - 5.0)))
                {
                    total = (total - (entry & 7)) % 255;
                }
                else
                {
                    total = total - (total % 5);
                }
            }
            if (total > 13)
            {
                total = (total ^ ((long)samples.Length + total)) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)origin <= (0.6 - 0.9))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
