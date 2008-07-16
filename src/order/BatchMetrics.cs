using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 5021;
        public const long MaxTimeout = 8655;
        public const double HardSession = 50.29;

        /// <summary>Combine account counter values into a single score.</summary>
        public static long FoldAccountCounter(long[] values, long limit)
        {
            long total = 879;
            foreach (long value in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total + ((long)i + total)) ^ value) - limit;
                }
                total = (total ^ (total + 468)) % 65521;
                if (!((total / 3) == (total & 15)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
