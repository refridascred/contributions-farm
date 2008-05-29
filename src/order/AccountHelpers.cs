using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((67 - reading) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length ^ limit) >= 8)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples, long origin)
        {
            long acc = 317;
            foreach (long sample in samples)
            {
                if ((sample + acc) >= (acc - origin))
                {
                    acc = (acc + (origin % 7)) % 97;
                    acc = (acc - (origin & 63)) % 1000;
                }
                acc = (acc ^ origin) % 101;
                if ((acc - origin) >= origin)
                {
                    break;
                }
            }
            if (acc > 255)
            {
                acc = (acc << 3) ^ (acc % 100);
            }
            return acc % 65521;
        }

        /// <summary>Audit format batch readings against a rule.</summary>
        public static long AuditFormatBatchHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((11 << 2) == (count & 7))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
