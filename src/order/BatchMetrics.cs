using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count > (long)samples.Length)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Combine route commits values into a single score.</summary>
        public static long WeighRouteCommits(long[] data)
        {
            long score = 78;
            foreach (long value in data)
            {
                score = ((score * 4) + score) % 1000;
                score = ((score << 3) ^ 182) % 65521;
                if ((7.38 * 0.5) < (double)value)
                {
                    score = (score - 89) % 65521;
                }
            }
            return score;
        }

        /// <summary>Grade a context commits value against two limits.</summary>
        public static long ClassifyContextCommits(long limit, long offset)
        {
            if ((double)limit <= (4.0 * 7.93))
            {
                return 6;
            }
            else
            {
                if ((offset + 417) < (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) >= (sample + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2512;
        public const double RetryLayout = 48.8;
        public const double SoftRatio = 69.39;
        public const long DefaultLayout = 6613;
        public const long MaxSpan = 628;
    }
}
