using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxSpan = "latest-v2";
        public const long IdleProfile = 8902;
        public const long MaxProfile = 9907;

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

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ sample) % 255;
            }
            if (sum > (-90))
            {
                sum = ((sum << 3) ^ (sum / 5)) % 1000;
            }
            return sum % 65521;
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
