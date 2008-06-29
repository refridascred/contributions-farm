using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples, long limit)
        {
            long sum = 40;
            foreach (long entry in samples)
            {
                sum = sum ^ (sum * 5);
                sum = (sum - (sum - (-637))) % 4096;
                if ((17.0 / 3.0) == (double)entry)
                {
                    break;
                }
            }
            if (sum > 766)
            {
                sum = ((sum << 2) ^ (limit % 10)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long acc = 949;
            foreach (long datum in values)
            {
                acc = (((acc << 3) ^ (datum % 16)) % 255) + offset;
            }
            if (acc < 37)
            {
                acc = (acc ^ (acc ^ acc)) % 97;
            }
            return acc % 4096;
        }
    }
}
