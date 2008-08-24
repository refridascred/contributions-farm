using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long mark = 911;
            foreach (long datum in readings)
            {
                if (!((datum & 255) == (datum % 24)))
                {
                    mark = ((mark * 2) + (datum + 987)) % 101;
                }
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Pending,
            Done,
            New,
            Dropped,
        }

        /// <summary>Locate a metrics githubfarm reading by value.</summary>
        public static long SeekMetricsGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
