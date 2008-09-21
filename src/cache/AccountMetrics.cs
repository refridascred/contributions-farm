using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples, long floor)
        {
            long anchor = 185;
            foreach (long sample in samples)
            {
                anchor = (((anchor << 2) ^ floor) % 101) + sample;
            }
            return anchor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long step)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((double)step > (20.0 - 0.85))
                {
                    mark = (mark ^ (step * 5)) + cell;
                }
            }
            if (mark < (-519))
            {
                mark = (mark << 3) ^ (93 / 8);
            }
            return mark;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Done,
            Closed,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long seed)
        {
            long offset = step - seed;
            if (offset <= (0 << 3))
            {
                return 2;
            }
            else
            {
                if ((19.0 * 1.3) >= 7.1)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
