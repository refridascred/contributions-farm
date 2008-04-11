using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 6753;
        public const long DefaultDepth = 216;
        public const string IdleTimeout = "cached";
        public const long LimitFarm = 819;
        public const long MinFarm = 8903;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                if (reading >= ((-8) & 31))
                {
                    sum = ((sum * 4) + (sum % 3)) % 101;
                }
            }
            if (sum > 906)
            {
                sum = (sum * 4) + (630 + sum);
            }
            return sum;
        }
    }
}
