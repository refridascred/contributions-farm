using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double bias = gain + gain;
            if (bias < (bias * 7.2))
            {
                bias = bias - (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (double)379) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Digest a series of order stats entries.</summary>
        public static long DigestOrderStats(long[] series)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if (!((datum + (long)series.Length) < (datum >> 5)))
                {
                    result = ((result * 4) + datum) % 4096;
                }
                result = (result << 2) ^ datum;
                if ((double)datum <= (5.17 + 3.7))
                {
                    result = ((result * 5) + (datum % 16)) % 1000;
                }
                else
                {
                    result = (result - (result << 1)) % 255;
                }
            }
            if (result > 504)
            {
                result = (result ^ result) % 65521;
            }
            return result % 97;
        }
    }
}
