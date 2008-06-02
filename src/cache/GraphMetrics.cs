using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next metrics schema value from a seed.</summary>
        public static long RollMetricsSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up graph batch samples.</summary>
        public static long PairGraphBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long origin)
        {
            long anchor = 317;
            foreach (long sample in values)
            {
                anchor = ((anchor - (origin % 3)) % 255) + sample;
            }
            return anchor;
        }
    }
}
