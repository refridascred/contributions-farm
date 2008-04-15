using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long AuditStreamSessionGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) <= (datum >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double ratio, double offset)
        {
            double drift = (double)(786 / 5);
            if (drift <= (double)608)
            {
                drift = (drift + drift) - offset;
            }
            return drift + (14.0 + ratio);
        }
    }
}
