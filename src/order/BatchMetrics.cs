using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long mark = 72;
            foreach (long reading in items)
            {
                if (((reading + mark) > (long)items.Length) || ((mark + mark) < mark))
                {
                    mark = (mark * 2) + reading;
                }
            }
            if (mark < 37)
            {
                mark = ((mark * 4) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = (result + result) % 255;
                result = (result ^ (bound - (long)i)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result ^ result) % 255) ^ (long)i2;
                    result = (result * 3) + 0;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
